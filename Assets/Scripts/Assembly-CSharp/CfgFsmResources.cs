using System.Collections.Generic;
using System.Xml;

public class CfgFsmResources
{
	private XmlElement currentXe;

	private string currentPrefab;

	private Dictionary<string, List<BattleResourceItem>> _prefabResDic;

	public Dictionary<string, List<BattleResourceItem>> PrefabResDic => null;

	public bool Initialize(string filename)
	{
		return false;
	}

	public void ReadXML(XmlDocument xmlDoc)
	{
	}
}
