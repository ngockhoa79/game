using System;
using System.Collections;
using System.Collections.Generic;
using Ice.ProjectCos.Config;
using UnityEngine;

public class LoginFsmStep2Manager : MonoBehaviour
{
	[SerializeField]
	private UILoginCGCtrl cgCtrller;

	[SerializeField]
	private LoginFsmManager fsmStep1;

	[SerializeField]
	private UILoginServerRoot loginServerRoot;

	[SerializeField]
	private UILabel lbName;

	[SerializeField]
	private LoginManager uiLogin;

	[SerializeField]
	private IceAnimatorTotalCommander animProgress;

	[SerializeField]
	private GameObject loadingRoot;

	[SerializeField]
	private UILabel lbTxt;

	private string authToken;
	private string xml;
	private bool bLogined;
	private bool bInitialized;
	private bool bUsingCYLogin;
	private bool bDefaultServer = true;
	private bool bAutoLoginMode;

	public static string curSelectServerInfoId = "900001";
	private string key;
	private string currentPort;
	private bool bIsShowingLoadingbar;
	private IEnumerator autoHideLoadingbar;

	private static MyServerInfo.ServerInfoTemplate s_curSelectServer;

	public static MyServerInfo.ServerInfoTemplate curSelectServer
	{
		get
		{
			if (s_curSelectServer == null)
			{
				s_curSelectServer = new MyServerInfo.ServerInfoTemplate();
				s_curSelectServer.ID = "900001";
				s_curSelectServer.IpAddress = "127.0.0.1";
				s_curSelectServer.Port = 16000;
				s_curSelectServer.Name = "LOCAL TEST";
				s_curSelectServer.State = 0;
			}
			return s_curSelectServer;
		}
	}

	private void Awake()
	{
		Debug.Log("[LOGIN-UI] LoginFsmStep2Manager.Awake");
		if (NetManager.Instance != null)
		{
			NetManager.Instance.E_OnLoginSuccess += InternalEnterGame;
			NetManager.Instance.E_OnLoginFail += ResetLogin;
		}
	}

	private void OnEnable()
	{
		Debug.Log("[LOGIN-UI] LoginFsmStep2Manager.OnEnable");
		PrepareLoginView();
	}

	private void Start()
	{
		Debug.Log("[LOGIN-UI] LoginFsmStep2Manager.Start");
		PrepareServerList();
	}

	private void OnDestroy()
	{
		if (NetManager.Instance != null)
		{
			NetManager.Instance.E_OnLoginSuccess -= InternalEnterGame;
			NetManager.Instance.E_OnLoginFail -= ResetLogin;
		}
	}

	public void TryLogin()
	{
		Debug.Log("[LOGIN-UI] TryLogin triggered");
		ShowBusyLoadingbar();
		
		MyServerInfo.ServerInfoTemplate server = curSelectServer;
		string host = (server != null && !string.IsNullOrEmpty(server.IpAddress)) ? server.IpAddress : "127.0.0.1";
		int port = (server != null && server.Port > 0) ? server.Port : 16000;
		string username = (lbName != null && !string.IsNullOrEmpty(lbName.text)) ? lbName.text : "testuser";
		string serverId = (server != null && !string.IsNullOrEmpty(server.ID)) ? server.ID : "900001";

		Debug.Log($"[LOGIN-UI] TryLogin: host={host}, port={port}, user={username}, serverId={serverId}");

		if (NetManager.Instance != null)
		{
			NetManager.Instance.Login(host, port, username, serverId);
		}
		else
		{
			Debug.LogError("[LOGIN-UI] NetManager.Instance is null!");
			HideBusyLoadingBar();
		}
	}

	public void StartProgress()
	{
		Debug.Log("[LOGIN-UI] StartProgress");
	}

	private void ResetLogin()
	{
		Debug.Log("[LOGIN-UI] ResetLogin");
		HideBusyLoadingBar();
		bLogined = false;
	}

	private void PrepareLoginView()
	{
		Debug.Log("[LOGIN-UI] PrepareLoginView");
		if (uiLogin != null)
		{
			uiLogin.E_OnEnterGame += OnEnterGameClicked;
		}
	}

	private void OnEnterGameClicked()
	{
		Debug.Log($"[LOGIN-UI] OnEnterGameClicked: bLogined={bLogined}");
		if (bLogined)
		{
			Debug.Log("[LOGIN-UI] bLogined is true -> calling InternalEnterGame() (second invocation)");
			InternalEnterGame();
		}
		else
		{
			Debug.Log("[LOGIN-UI] bLogined is false -> calling TryLogin()");
			TryLogin();
		}
	}

	private void InternalEnterGame()
	{
		Debug.Log($"[LOGIN-UI] InternalEnterGame called (bLogined was {bLogined})");
		HideBusyLoadingBar();
		bLogined = true;

		var sceneMgr = GlobalManager.Instance != null ? GlobalManager.Instance.SceneManager : UnityEngine.Object.FindObjectOfType<SceneManager>();
		if (sceneMgr != null)
		{
			Debug.Log("[LOGIN-UI] Initiating natural main stage transition: Calling SceneManager.EnterMainStage(false)");
			sceneMgr.EnterMainStage(false);
		}
		else
		{
			Debug.LogError("[LOGIN-UI] SceneManager instance not found!");
		}
	}

	public void ShowBusyLoadingbar()
	{
		bIsShowingLoadingbar = true;
		if (loadingRoot != null)
		{
			loadingRoot.SetActive(true);
		}
	}

	public void HideBusyLoadingBar()
	{
		bIsShowingLoadingbar = false;
		if (loadingRoot != null)
		{
			loadingRoot.SetActive(false);
		}
	}

	private void PrepareServerList()
	{
		Debug.Log("[LOGIN-UI] PrepareServerList");
	}

	public void FinishAnnounceNotification()
	{
		string savedServerId = PlayerPrefs.GetString("LastSelectServerID", "");
		Debug.Log("FinishAnnounceNotification: " + xml);

		List<LoginServerInfo> list = new List<LoginServerInfo>();
		if (Common.ServerInfo != null && Common.ServerInfo.Templates != null)
		{
			foreach (MyServerInfo.ServerInfoTemplate template in Common.ServerInfo.Templates)
			{
				LoginServerInfo serverInfo = LoginServerInfo.ConvertFrom(template);
				if (serverInfo != null)
				{
					list.Add(serverInfo);
					if (!string.IsNullOrEmpty(serverInfo.Id) && string.Equals(serverInfo.Id, savedServerId))
					{
						curSelectServerInfoId = serverInfo.Id;
					}
				}
			}
		}

		bDefaultServer = true;
		if (string.IsNullOrEmpty(curSelectServerInfoId))
		{
			if (list != null && list.Count > 0)
			{
				LoginServerInfo lastServer = list[list.Count - 1];
				if (lastServer != null)
				{
					curSelectServerInfoId = lastServer.Id;
				}
				bDefaultServer = false;
			}
		}

		EnterDeviceMode();
	}

	private void EnterEditorMode()
	{
		Debug.Log("[LOGIN-UI] EnterEditorMode");
	}

	private void EnterDeviceMode()
	{
		Debug.Log("[LOGIN-UI] EnterDeviceMode");
		bUsingCYLogin = true;
		if (!bLogined)
		{
			TryLogin();
		}
		else
		{
			if (uiLogin != null)
			{
				uiLogin.RefreshView();
			}
			PrepareLoginView();
		}
	}

	private string SignMD5()
	{
		return string.Empty;
	}
}
