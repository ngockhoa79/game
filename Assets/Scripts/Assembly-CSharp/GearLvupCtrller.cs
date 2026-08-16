using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearLvupCtrller : IceUIBase
{
	public GearLvupHeadCtrller HeadCtrller;

	public GearLvupDataCtrller DataCtrller;

	public GearLvupResultCtrller ResultCtrller;

	public UIEventListener LvupBtn;

	public UIEventListener AutoLvupBtn;

	public UILabel CoinLabel;

	public UILabel ConsumeLabel;

	public UISprite ConsumeCoin;

	public IceAnimatorTotalCommander PickAnim;

	public IceAnimatorTotalCommander BtnsAnim;

	private GearHolding gear;

	private int lvupCost;

	private int coinCounter;

	private bool isAutoUp;

	private bool IsIllegalState => false;

	protected override void DoPrepare()
	{
	}

	public void SetData(GearHolding _gearHolding, bool _needRefreshAll = true)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	private void Update()
	{
	}

	private void OnLevelupClicked(GameObject _object)
	{
	}

	private void OnAutoLevelupClicked(GameObject _object)
	{
	}

	private void OnLevelupResponse(object _msg)
	{
	}
}
