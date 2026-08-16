using System.Collections.Generic;
using System.Xml;

namespace Ice.Client
{
	public class CfgBuildTargetDesc
	{
		public string PrefabDirectory;

		public string SceneDirectory;

		public string MusicDirectory;

		public string TextureDirectory;

		public string UIAtlasDirectory;

		public string OutputDirectory;

		public string ConfigDirectory;

		private Dictionary<string, List<BuildTargetContent>> _buildTargetList;

		public Dictionary<string, List<BuildTargetContent>> BuildTargetList => null;

		public bool Initialize(string filename)
		{
			return false;
		}

		public void ReadXML(XmlDocument xmlDoc)
		{
		}

		public BuildTargetContent GetBuildConfig(string loadResourceType, string languageVersion)
		{
			return null;
		}

		public string GetRealLanguageVersion(string loadResourceType, string defaultLanguageVersion)
		{
			return null;
		}
	}
}
