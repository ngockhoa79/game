using System.Collections.Generic;
using System.Xml;

namespace Ice.Client
{
	public class CfgGameSettingsDesc
	{
		private Dictionary<string, string> _appSettings;

		public Dictionary<string, string> AppSettings => null;

		public bool Initilaize(string filename)
		{
			return false;
		}

		public void ReadXML(XmlDocument xmlDoc)
		{
		}
	}
}
