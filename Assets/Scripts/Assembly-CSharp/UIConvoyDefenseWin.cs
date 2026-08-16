using System;
using UnityEngine;

public class UIConvoyDefenseWin : UIConvoyPopupBase
{
	public UILabel EnemyName;

	public UILabel PlayerGain;

	public UILabel ShipGain;

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

	public void SetData(string enemy, int playerCoin, int shipCoin)
	{
	}

	public void OnClose(GameObject clickedButton)
	{
	}

	public override void ClosePanel()
	{
	}
}
