using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIConvoyScoreboard : UIConvoyPopupBase
{
	public UILabel LabelConclusion;

	public UILabel LabelTotalShips;

	public UILabel LabelDefenseWin;

	public UILabel LabelDefenseLose;

	public UILabel LabelLootWin;

	public UILabel LabelLootLose;

	public UILabel LabelGainValue;

	public UILabel LabelLoseValue;

	public UILabel LabelTotalExp;

	public UIEventListener ButtonOK;

	public Action E_OnPanelClose;

	protected override void SetID()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetData(EscortPlayerInfoProto.EscortRecord recordProto)
	{
	}

	public void OnClose(GameObject clickedButton)
	{
	}

	public override void ClosePanel()
	{
	}
}
