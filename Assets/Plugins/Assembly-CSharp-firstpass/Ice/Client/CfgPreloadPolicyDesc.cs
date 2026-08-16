using System.Collections.Generic;
using System.Xml;

namespace Ice.Client
{
	public class CfgPreloadPolicyDesc
	{
		private Dictionary<int, PreloadPolicyContent> _preloadPolicyList;

		public Dictionary<int, PreloadPolicyContent> PreloadPolicyList => null;

		public bool Initilaize(string filename)
		{
			return false;
		}

		public void ReadXML(XmlDocument xmlDoc)
		{
		}
	}
}
