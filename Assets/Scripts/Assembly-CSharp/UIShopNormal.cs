using System;
using UnityEngine;

public class UIShopNormal : UIShopBase
{
	public UpdateTimerUTC TimeAutoRefresh;

	public UIEventListener EventRefresh;

	public UILabel lbRefreshCost;

	public UICostDisplayer RefreshCost;

	public GameObject NPC;

	protected override void DoInit()
	{
	}

	protected override void DoDispose()
	{
	}

	public override string OnGetItemName()
	{
		return null;
	}

	public override void SetUI(int value = 0)
	{
	}

	public override void OnOpenShop()
	{
	}

	private void requestShopItemCheckTimer()
	{
	}

	public string OnGetFreeRefreshTimeString(TimeSpan d)
	{
		return null;
	}

	private void timerShowNextFreeTime()
	{
	}

	public void OpenRefreshDialog()
	{
	}

	public void OnAutoRefreshShop(UpdateTimerUTC timer)
	{
	}

	public bool IsNearAutoRefresh()
	{
		return false;
	}

	protected bool isCostEnoughToRefresh()
	{
		return false;
	}

	protected void refreshShopIfCostEnough()
	{
	}

	public void ActivateNPC(bool isShow)
	{
	}
}
