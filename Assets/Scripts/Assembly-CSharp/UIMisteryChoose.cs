using System;
using Ice.ProjectCos.UI.DataModel;

public class UIMisteryChoose : IceUIBase
{
	public UIEventListener eventOutMain;

	public UIEventListener eventOutBack;

	public UIEventListener eventChallage1;

	public UIEventListener eventChallage2;

	public UIEventListener eventChallage3;

	public UILabel lbEasyBattleValue;

	public UILabel lbNormalBattleValue;

	public UILabel lbHardBattleValue;

	public UpdateTimerUTC TimerDispear;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void GotoMisteryShop(ShopType shopType)
	{
	}
}
