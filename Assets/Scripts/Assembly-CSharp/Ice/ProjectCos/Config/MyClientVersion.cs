namespace Ice.ProjectCos.Config
{
	public class MyClientVersion
	{
		public string RemoteClientVersion;

		public string ClientContent;

		public string UpdateUrl;

		public void LoadFromXml(string xml)
		{
		}

		public bool NeedUpdateVersion(string version)
		{
			return false;
		}
	}
}
