using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIFragmentRobTarget : IceUIBase
{
	public UILabel lbFightValue;

	public UILabel lbLevel;

	public UILabel lbName;

	public UILabel lbGuildName;

	public GameObject CharacterRoot;

	public UIEventListener btnOnSelect;

	public Action<S2CRobberyOpponentsAck.TargetInfoProto> E_OnSelectTarget;

	public Action E_OnInited;

	public float scale;

	public IceAnimatorTotalCommander animEnter;

	[SerializeField]
	private UILabel lbProhability;

	private UIHeroLoader _heroLoader;

	private S2CRobberyOpponentsAck.TargetInfoProto _data;

	public void SetData(S2CRobberyOpponentsAck.TargetInfoProto snapShot)
	{
	}

	public void ShowCharacter(bool bShow)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}
}
