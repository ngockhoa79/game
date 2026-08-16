using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using ProtoBuf;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using Ice.ServerFramework.Protocol;
using Ice.SampleGame.LibClient;
using UnityEngine;

public class NetManager : MonoBehaviour, IClientEventHandler
{
	public enum CoreErrorCode
	{
		NetWorkTimeOut = 0,
		NetWorkMessageRemoved = 1,
		ErrorCodeUnknown = 2
	}

	private const int TRY_LOGIN_MAX_COUNT = 3;

	private static NetManager instance_;
	public static NetManager Instance
	{
		get
		{
			if (instance_ == null)
			{
				NetManager existing = GameObject.FindObjectOfType<NetManager>();
				if (existing != null)
				{
					instance_ = existing;
				}
				else
				{
					GameObject go = new GameObject("NetManager");
					instance_ = go.AddComponent<NetManager>();
					if (Application.isPlaying)
					{
						DontDestroyOnLoad(go);
					}
					Debug.Log("[NET] NetManager singleton created on-demand");
				}
			}
			return instance_;
		}
	}

	private AsynchronousClient client_;
	private string sessionToken_;
	private int tryLoginCount;

	public Action E_OnLoginFail;
	public Action E_OnLoginSuccess;
	public Action<S2CHeroLotteryAck> E_OnHeroLotteryAck;

	private string[] kickStrings;
	private IEnumerator waitCloseLoadingBar;
	private const int kAckTimeoutInterval = 20000;

	private Dictionary<int, Action<object, int>> messageIntercepters_ = new Dictionary<int, Action<object, int>>();

	private Socket m_Socket;
	private byte[] m_ReceiveBuffer = new byte[65536];
	private MemoryStream m_StreamBuffer = new MemoryStream();
	private string m_Host;
	private int m_Port;
	private string m_Username;
	private string m_ServerId;
	private string m_AuthToken;
	private bool m_IsConnected;

	public string SessionToken => sessionToken_;

	private void Awake()
	{
		if (instance_ == null)
		{
			instance_ = this;
			if (Application.isPlaying)
			{
				DontDestroyOnLoad(gameObject);
			}
			Debug.Log("[NET] NetManager singleton initialized in Awake");
		}
		else if (instance_ != this)
		{
			Destroy(gameObject);
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
		PollSocketMessages();
	}

	public void Login(string host, int port, string username, string server_id)
	{
		m_Host = host;
		m_Port = port;
		m_Username = username;
		m_ServerId = server_id;
		m_AuthToken = BuildAuthToken(username, server_id);

		Debug.Log($"[NET] Login: host={host}, port={port}, username={username}, server_id={server_id}, token={m_AuthToken}");
		LoginByAuthToken(host, port, m_AuthToken, "1.0");
	}

	private string BuildAuthToken(string username, string serverId)
	{
		if (string.IsNullOrEmpty(username))
		{
			username = "testuser";
		}
		string token = $"{username}_{serverId}";
		Debug.Log($"[TRACE 10/19] BuildAuthToken(): {token}");
		return token;
	}

	private void LoginByAuthToken(string host, int port, string authToken, string clientVersion)
	{
		Debug.Log($"[TRACE 11/19] TCP Connect {host}:{port}");
		try
		{
			if (m_Socket != null && m_Socket.Connected)
			{
				m_Socket.Close();
			}

			m_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			m_Socket.NoDelay = true;
			m_Socket.BeginConnect(host, port, OnConnectCallback, m_Socket);
		}
		catch (Exception ex)
		{
			Debug.LogError($"[NET] Socket connect exception: {ex.Message}");
			E_OnLoginFail?.Invoke();
		}
	}

	private void OnConnectCallback(IAsyncResult ar)
	{
		try
		{
			Socket socket = (Socket)ar.AsyncState;
			socket.EndConnect(ar);
			m_IsConnected = true;
			Debug.Log("[NET] TCP socket connected successfully!");

			OnConnected();
		}
		catch (Exception ex)
		{
			Debug.LogError($"[NET] Connect failed: {ex.Message}");
			m_IsConnected = false;
			E_OnLoginFail?.Invoke();
		}
	}

	public void OnConnected()
	{
		Debug.Log("[TRACE 12/19] MsgId 3 (LoginByAuthTokenReq)");
		var req = new LoginByAuthTokenReq
		{
			AuthToken = m_AuthToken,
			ClientVersion = "1.0"
		};
		Debug.Log($"[NET-DIAG] LoginByAuthTokenReq fields: AuthToken='{req.AuthToken}', ClientVersion='{req.ClientVersion}'");
		SendPacket(3, req);
	}

	public void SendPacket<T>(int msgId, T payload)
	{
		if (m_Socket == null || !m_Socket.Connected)
		{
			Debug.LogError("[NET] Cannot send packet: Socket not connected");
			return;
		}

		try
		{
			using (MemoryStream ms = new MemoryStream())
			{
				Serializer.Serialize(ms, payload);
				byte[] payloadBytes = ms.ToArray();
				int totalLength = 8 + payloadBytes.Length;

				Debug.Log($"[NET-DIAG] Serialized type={typeof(T).FullName} PayloadBytes={payloadBytes.Length} Hex={System.BitConverter.ToString(payloadBytes)}");

				using (MemoryStream packetStream = new MemoryStream())
				{
					using (BinaryWriter writer = new BinaryWriter(packetStream))
					{
						writer.Write(totalLength);
						writer.Write(msgId);
						writer.Write(payloadBytes);
					}

					byte[] packetBytes = packetStream.ToArray();
					m_Socket.Send(packetBytes);
					Debug.Log($"[PACKET] TX MsgId={msgId} TotalLength={totalLength} PayloadBytes={payloadBytes.Length}");
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError($"[NET] SendPacket exception for MsgId={msgId}: {ex}");
		}
	}

	private void PollSocketMessages()
	{
		if (m_Socket == null || !m_Socket.Connected) return;

		try
		{
			while (m_Socket.Available > 0)
			{
				int bytesRead = m_Socket.Receive(m_ReceiveBuffer, 0, m_ReceiveBuffer.Length, SocketFlags.None);
				if (bytesRead > 0)
				{
					m_StreamBuffer.Write(m_ReceiveBuffer, 0, bytesRead);
				}
			}

			m_StreamBuffer.Position = 0;
			while (m_StreamBuffer.Length - m_StreamBuffer.Position >= 8)
			{
				long startPos = m_StreamBuffer.Position;
				byte[] header = new byte[8];
				m_StreamBuffer.Read(header, 0, 8);

				int totalLength = BitConverter.ToInt32(header, 0);
				int msgId = BitConverter.ToInt32(header, 4);

				int payloadLength = totalLength - 8;
				if (m_StreamBuffer.Length - m_StreamBuffer.Position < payloadLength)
				{
					// Partial packet received; rewind
					m_StreamBuffer.Position = startPos;
					break;
				}

				byte[] payload = new byte[payloadLength];
				if (payloadLength > 0)
				{
					m_StreamBuffer.Read(payload, 0, payloadLength);
				}

				Debug.Log($"[PACKET] RX MsgId={msgId} TotalLength={totalLength} PayloadBytes={payloadLength}");
				ProcessIncomingMessage(msgId, payload);
			}

			// Compact remaining buffer
			if (m_StreamBuffer.Position > 0)
			{
				byte[] remaining = new byte[m_StreamBuffer.Length - m_StreamBuffer.Position];
				m_StreamBuffer.Read(remaining, 0, remaining.Length);
				m_StreamBuffer = new MemoryStream();
				m_StreamBuffer.Write(remaining, 0, remaining.Length);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError($"[NET] Error processing socket messages: {ex.Message}");
		}
	}

	private void ProcessIncomingMessage(int msgId, byte[] payload)
	{
		using (MemoryStream ms = new MemoryStream(payload))
		{
			switch (msgId)
			{
				case 2: // MsgId_LoginByAuthTokenAck
					var authAck = Serializer.Deserialize<LoginByAuthTokenAck>(ms);
					Debug.Log($"[PACKET] RX LoginByAuthTokenAck (2): Result={authAck.Result}, SessionToken={authAck.SessionToken}");
					OnLoginByAuthTokenAck((LoginByAuthTokenResoult)authAck.Result, authAck.SessionToken);
					break;

				case 1: // MsgId_LoginBySessionTokenAck
					var sessionAck = Serializer.Deserialize<LoginBySessionTokenAck>(ms);
					Debug.Log($"[PACKET] RX LoginBySessionTokenAck (1): Result={sessionAck.Result}");
					OnLoginBySessionTokenAck((LoginBySessionTokenResoult)sessionAck.Result, sessionToken_);
					break;

				case 1175: // MsgId_S2CEnterGameAllInfoNtf
					var enterInfo = Serializer.Deserialize<S2CEnterGameAllInfoNtf>(ms);
					Debug.Log($"[ENTER-GAME] RX S2CEnterGameAllInfoNtf (1175): PlayerAllInfo received!");
					OnEnterGameAllInfoNtf(enterInfo);
					break;

				case 1247: // MsgId_S2CHeroLotteryAck
					var lotteryAck = Serializer.Deserialize<S2CHeroLotteryAck>(ms);
					Debug.Log($"[LOTTERY] RX S2CHeroLotteryAck (1247): Code={lotteryAck.Code}, HerosCount={lotteryAck.Heros?.Count}");
					E_OnHeroLotteryAck?.Invoke(lotteryAck);
					break;

				default:
					Debug.Log($"[NET] Unhandled MsgId={msgId}");
					break;
			}
		}
	}

	public void OnLoginByAuthTokenAck(LoginByAuthTokenResoult code, string sessionToken)
	{
		Debug.Log($"[TRACE 13/19] MsgId 2 (LoginByAuthTokenAck): result={code}");
		if (code == LoginByAuthTokenResoult.GAMESERVER_AUTHLOGIN_RESULT_OK && !string.IsNullOrEmpty(sessionToken))
		{
			sessionToken_ = sessionToken;
			Debug.Log($"[TRACE 14/19] sessionToken_ = {sessionToken_}");
			LoginBySessionToken(sessionToken_);
		}
		else
		{
			Debug.LogError($"[AUTH] LoginByAuthTokenAck failed with result {code}");
			E_OnLoginFail?.Invoke();
		}
	}

	private void LoginBySessionToken(string sessionToken)
	{
		Debug.Log("[TRACE 15/19] MsgId 4 (LoginBySessionTokenReq)");
		var req = new LoginBySessionTokenReq
		{
			SessionToken = sessionToken,
			ClientVersion = "1.0"
		};
		SendPacket(4, req);
	}

	public void OnLoginBySessionTokenAck(LoginBySessionTokenResoult code, string sessionToken)
	{
		Debug.Log($"[TRACE 16/19] MsgId 1 (LoginBySessionTokenAck): result={code}");
		if (code == LoginBySessionTokenResoult.GAMESERVER_SESSIONLOGIN_RESULT_OK)
		{
			sessionToken_ = sessionToken;
			Debug.Log("[TRACE 17/19] E_OnLoginSuccess fired");
			E_OnLoginSuccess?.Invoke();
		}
		else
		{
			Debug.LogError($"[AUTH] LoginBySessionTokenAck failed with result {code}");
			E_OnLoginFail?.Invoke();
		}
	}

	private void OnEnterGameAllInfoNtf(S2CEnterGameAllInfoNtf ntf)
	{
		Debug.Log("[NET-DIAG] MsgId 1175 (S2CEnterGameAllInfoNtf) received!");
		if (ntf != null && ntf.PlayerAllInfo != null)
		{
			var info = ntf.PlayerAllInfo;
			int crystal = info.PropertyBaseInfo != null ? info.PropertyBaseInfo.Crystal : -1;
			int level = info.PropertyBaseInfo != null ? info.PropertyBaseInfo.Level : -1;
			bool formValid = info.FormationInfo != null;
			int heroIndicesCount = (formValid && info.FormationInfo.HerosIndexList != null) ? info.FormationInfo.HerosIndexList.Count : 0;
			Debug.Log($"[NET-DIAG-1175] PlayerAllInfo summary: Level={level}, Crystal={crystal}, FormationInfo!=null={formValid}, HerosIndexList.Count={heroIndicesCount}");

			if (Me.Ins != null)
			{
				Me.Ins.FromProto(ntf.PlayerAllInfo);
				Me.Ins.SetDataOk = true;
			}
			Debug.Log("[NET-DIAG] Me.FromProto completed -> Me.SetDataOk = true");
		}
		else
		{
			Debug.LogWarning("[NET-DIAG-1175] Received S2CEnterGameAllInfoNtf but ntf or ntf.PlayerAllInfo is null!");
		}
	}

	public void OnDisconnected(ConnectionStatus status, SocketError errorCode)
	{
		Debug.LogWarning($"[NET] OnDisconnected: status={status}, errorCode={errorCode}");
		m_IsConnected = false;
	}

	public void OnError(int msgId)
	{
		Debug.LogError($"[NET] OnError: msgId={msgId}");
	}

	public void OnMessage(object msg, int msgId)
	{
		Debug.Log($"[NET] OnMessage received MsgId={msgId}, type={msg?.GetType().Name}");
		if (messageIntercepters_ != null && messageIntercepters_.TryGetValue(msgId, out var handler))
		{
			handler?.Invoke(msg, msgId);
		}
		if (msg is LoginByAuthTokenAck authAck)
		{
			OnLoginByAuthTokenAck((LoginByAuthTokenResoult)authAck.Result, authAck.SessionToken);
		}
		else if (msg is LoginBySessionTokenAck sessionAck)
		{
			OnLoginBySessionTokenAck((LoginBySessionTokenResoult)sessionAck.Result, sessionToken_);
		}
		else if (msg is S2CEnterGameAllInfoNtf enterGameInfo)
		{
			OnEnterGameAllInfoNtf(enterGameInfo);
		}
	}

	public void SendMessage(object msg)
	{
	}

	public void SendMessage(object msg, int ackId, Action<object, int> respondHandler, Action<CoreErrorCode> failHander, bool bShowLoadingBlock = true)
	{
	}

	public void RegisterMessageHandler(int msgId, Action<object, int> handler, bool isOnce)
	{
		messageIntercepters_[msgId] = handler;
	}

	public void UnRegisterMessageHandler(int msgId, Action<object, int> handler)
	{
		if (messageIntercepters_.ContainsKey(msgId))
		{
			messageIntercepters_.Remove(msgId);
		}
	}

	public void ReturnToLoginScreen(string tipString)
	{
		Debug.Log($"[NET] ReturnToLoginScreen: {tipString}");
	}

	public bool IsCloseServer(SocketError errorCode)
	{
		return false;
	}

	public void Shutdown()
	{
		if (m_Socket != null)
		{
			m_Socket.Close();
			m_Socket = null;
		}
	}

	public void ShutdownNoMsg()
	{
		Shutdown();
	}
}
