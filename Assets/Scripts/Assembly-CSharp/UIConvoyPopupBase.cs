using System;

public abstract class UIConvoyPopupBase : IceUIBase
{
	public enum PopupID
	{
		LootWin = 0,
		LootLose = 1,
		DefenseWin = 2,
		DefenseLose = 3,
		Scoreboard = 4,
		ConvoyFinish = 5,
		SelfInfo = 6,
		InterceptInfo = 7,
		ShipList = 8,
		Report = 9,
		Rule = 10,
		Invalid = 11
	}

	public Action<PopupID> E_OnCloseBase;

	public PopupID PanelID;

	protected abstract void SetID();

	public abstract void ClosePanel();

	protected override void DoInit()
	{
	}

	protected override void DoDispose()
	{
	}
}
