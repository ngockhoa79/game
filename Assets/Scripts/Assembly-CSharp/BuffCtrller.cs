using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class BuffCtrller : MonoBehaviour
{
	[HideInInspector]
	public BuffStage buffStage;

	private GameObject attachHero;

	public int buffId;

	public int sourceFighterId;

	public int attachFighterId;

	private int ChildrenFsmFinishCount;

	private PlayMakerFSM attachFsm;

	private GameObject standardAffactObject;

	private PlayMakerFSM[] affectHerosFsm;

	public HashSet<int> affactFighters;

	private Dictionary<int, PlayMakerFSM> affactFsms;

	private List<PropertyChangeProto> propertyChangeList;

	public void InitBuff(BattleBuffInfo _info, BuffStage _stage)
	{
		buffStage = _stage;
		if (_info != null)
		{
			buffId = _info.BuffId;
			sourceFighterId = _info.SourceFighterId;
			attachFighterId = _info.AttachFighterId;
		}
		gameObject.SetActive(true);
	}

	private void SetAffactFsms()
	{
	}

	private void SetAffactFsm(int _fighterId, string _objectName)
	{
	}

	private void SetLeaderFsm()
	{
	}

	private void NotifyAllInitOver()
	{
	}

	public void SetProperty(PropertyChangeProto _property)
	{
		if (_property == null) return;
		if (propertyChangeList == null) propertyChangeList = new List<PropertyChangeProto>();
		propertyChangeList.Add(_property);
	}

	public void SetProperty(List<PropertyChangeProto> _property)
	{
		if (_property != null)
		{
			propertyChangeList = _property;
		}
	}

	public void HandleMsg(BuffCtrllerMsgType _msg, GameObject _object)
	{
	}

	public bool GetIsImmune(GameObject _object)
	{
		return false;
	}

	private void HandleChangeProperty(GameObject _hero)
	{
	}

	public void FinishLastBuff()
	{
	}

	private void HandleChildFsmFinish(GameObject _child)
	{
	}

	public void DestroyBuff()
	{
	}

	public void ClearAll()
	{
	}

	private void OnDestroy()
	{
	}

	private void CheckFighterDie()
	{
	}
}
