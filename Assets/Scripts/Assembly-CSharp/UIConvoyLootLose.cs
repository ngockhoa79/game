using System;
using UnityEngine;

public class UIConvoyLootLose : UIConvoyPopupBase
{
	public UILabel Message;

	public UILabel GoldLost;

	public UILabel LootTimesLeft;

	public UIEventListener ButtonOK;

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

	public void SetData(int goldLost, int timesLeft)
	{
	}

	public void OnClose(GameObject clickedButton)
	{
	}

	public override void ClosePanel()
	{
	}
}
