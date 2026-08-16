using System;

namespace Ice.SampleGame.LibClient
{
	public class SessionToken
	{
		public string AuthId;

		public string ServerAddress;

		public int ServerPort;

		public DateTime TimeStamp;

		public string SessionTokenOriginal;

		public static SessionToken GetSessionObject(string sessionToken)
		{
			return null;
		}
	}
}
