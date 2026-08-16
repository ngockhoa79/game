using System;
using System.Net.Sockets;

namespace Ice.SampleGame.LibClient
{
	public sealed class AsynchronousClient
	{
		private sealed class AuthTokenClient : Client
		{
			private IClientEventHandler clientEventHandler_;

			public string AuthToken { get; private set; }

			public string ClientVersion { get; private set; }

			public AuthTokenClient(Action<Action> postAction, IClientEventHandler clientEventHandler, string authToken, string clientVersion)
				: base(null)
			{
			}

			protected override void OnConnected()
			{
			}

			protected override void OnDisconnected(SocketError errorCode)
			{
			}

			protected override void OnReceiveMessage(object msg)
			{
			}
		}

		private sealed class SessionClient : Client
		{
			private IClientEventHandler clientEventHandler_;

			private Action<object> messageHookAction_;

			public string SessionToken { get; private set; }

			public string ClientVersion { get; private set; }

			public SessionClient(Action<Action> postAction, IClientEventHandler clientEventHandler, string sessionToken, string clientVersion)
				: base(null)
			{
			}

			protected override void OnConnected()
			{
			}

			protected override void OnDisconnected(SocketError errorCode)
			{
			}

			protected override void OnReceiveMessage(object message)
			{
			}

			private void HandleCommonMsg(object msg)
			{
			}

			private void LoginBySessionTokenAck(object msg)
			{
			}
		}

		private readonly IClientEventHandler clientEventHandler_;

		private readonly Action<Action> posAction_;

		private AuthTokenClient authTokenClient_;

		private SessionClient sessionClient_;

		public bool IsClosed => false;

		private bool IsAuthTokenClientClosed => false;

		private bool IsSessionClientClosed => false;

		public AsynchronousClient(IClientEventHandler handler, Action<Action> posAction)
		{
		}

		private bool SendAsyc(object msg)
		{
			return false;
		}

		public bool LoginByAuthToken(string serverHost, int serverPort, string authToken, string clientVersion)
		{
			return false;
		}

		public bool LoginBySessionToken(string sessionToken, string clientVersion)
		{
			return false;
		}

		public void CloseAuthTokenClient()
		{
		}

		public void CloseSessionClient()
		{
		}

		public void CloseAll()
		{
		}

		public bool SendMessage(object msg)
		{
			return false;
		}
	}
}
