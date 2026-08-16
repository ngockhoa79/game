using System;
using UnityEngine;

public class UIConvoyDefenseLose : UIConvoyPopupBase
{
	public UILabel EnemyName;

	public UILabel ShipName;

	public UILabel GoldGain;

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

	public void SetData(string playerName, string shipName, int gold)
	{
	}

	public void OnClose(GameObject clickedButton)
	{
	}

	public override void ClosePanel()
	{
	}
}
