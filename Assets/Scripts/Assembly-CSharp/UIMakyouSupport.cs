using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIMakyouSupport : IceUIBase
{
	public UIEventListener CloseButton;

	public MakyouSupportPlayer PlayerA;

	public MakyouSupportPlayer PlayerB;

	public Action E_InfoChanged;

	protected CrossPersonPlayOffInfoProto.BattleOnceProto BattleInfo;

	protected int BattleIndex;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void SetData(CrossPersonPlayOffInfoProto.BattleOnceProto fightInfo, int battleIndex)
	{
	}

	private void OnClose(GameObject btn)
	{
	}

	private void OnSupportClick(MakyouSupportPlayer.PlayerPosition side)
	{
	}

	private void RefreshUI()
	{
	}
}
