using System.Collections.Generic;

namespace Ice.ProjectCos.Config
{
	public class MyServerInfo
	{
		public class ServerInfoTemplate
		{
			public List<string> WhiteIPList;

			public EServerState State { get; set; }

			public string DisplayID { get; set; }

			public string ID { get; set; }

			public string Name { get; set; }

			public string IpAddress { get; set; }

			public int Port { get; set; }

			public string MessageStop { get; set; }

			public string MessageFull { get; set; }

			public bool CanEnter { get; set; }
		}

		public enum EServerState
		{
			Normal = 0,
			Hot = 1,
			StopServer = 2
		}

		private List<ServerInfoTemplate> _templates;

		private List<string> _lastLoginServerId;

		public string SelectServerName;

		public int SelectServerPort;

		private string _resourcesUrl;

		private bool _showBulletin;

		public List<ServerInfoTemplate> Templates => _templates;

		public List<ServerInfoTemplate> LastLoginServer => null;

		public string SelectServerID { get; set; }

		public string ResourcesUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ShowBulletin
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string DefaultMessageStop { get; set; }

		public string DefaultMessageFull { get; set; }

		public void LoadFromXml(string xml)
		{
		}

		public void PushLastLoginServer(string server_id)
		{
		}

		public string GetCurServerFullMessage()
		{
			return null;
		}

		public string GetCurServerStopMessage()
		{
			return null;
		}

		public void CleanLastLoginServerId()
		{
		}
	}
}
