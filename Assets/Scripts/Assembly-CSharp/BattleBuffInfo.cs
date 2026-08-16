using Ice.ProjectCos.Protocol;
using UnityEngine;

public class BattleBuffInfo
{
	public int UniqueId;

	public int BuffId;

	public int SourceFighterId;

	public int AttachFighterId;

	public GameObject AttachObject;

	public GameObject EffectObject;

	public GameObject LastObject;

	public GameObject RemoveObject;

	public BattleBuffInfo()
	{
	}

	public BattleBuffInfo(BuffAddProto _proto)
	{
	}

	public BattleBuffInfo(BuffActionEffectProto _proto)
	{
	}
}
