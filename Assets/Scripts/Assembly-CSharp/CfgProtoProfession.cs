using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class CfgProtoProfession
{
	private Dictionary<int, ProfessionKeyTimes> _animationKeyTimeDic;

	private Dictionary<int, ProfessionSkillDistance> _skillDistanceDic;

	private Dictionary<int, ProfessionPositions> _positionDic;

	public Dictionary<int, ProfessionKeyTimes> AnimationKeyTimeDic => null;

	public Dictionary<int, ProfessionSkillDistance> SkillDistanceDic => null;

	public Dictionary<int, ProfessionPositions> PositionDic => null;

	public bool Initialize(string filename)
	{
		return false;
	}

	public void ReadXML(XmlDocument xmlDoc)
	{
	}

	public float GetKeyTime(int _professionIndex, string _keyName)
	{
		return 0f;
	}

	public float GetSkillDistance(int _professionIndex, string _type)
	{
		return 0f;
	}

	public Vector3 GetPosition(int _professionIndex, string _type)
	{
		return default(Vector3);
	}
}
