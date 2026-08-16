namespace Ice.SampleGame.LibClient
{
	internal class LibClientStateMachine : StateMachine
	{
		public const int STATE_IDLE = 0;

		public const int STATE_AUTHLOGIN_CONNECTING = 1;

		public const int STATE_AUTHLOGIN_CONNECTED = 2;

		public const int STATE_AUTHLOGIN_OK_NEED_REDIRECT = 3;

		public const int STATE_SESSIONLOGIN_CONNECTING = 4;

		public const int STATE_SESSIONLOGIN_CONNECTED = 5;

		public const int STATE_LOGIN_OK = 6;

		public const int STATE_DISCONNECTING = 99;

		public const int STATE_DISCONNECTED = 100;

		public const int EVENT_AUTHLOGIN_CONNECT = 1;

		public const int EVENT_ONCONNECTED = 2;

		public const int EVENT_DISCONNECT = 3;

		public const int EVENT_ONDISCONNECTED = 4;

		public const int EVENT_AUTHLOGIN_OK = 5;

		public const int EVENT_AUTHLOGIN_OK_REDRIECT = 6;

		public const int EVENT_AUTHLOGIN_FAIL = 7;

		public const int EVENT_SESSIONLOGIN_CONNECT = 8;

		public const int EVENT_SESSIONLOGIN_OK = 9;

		public const int EVENT_SESSIONLOGIN_FAIL = 10;

		public override int SetStateCheck(int commingEvent, int newState = -1, bool testOnly = false)
		{
			return 0;
		}
	}
}
