using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIWeekVipGift : IceUIBase
{
	private int CurrentIndex;

	protected Dictionary<int, int> VIPLevelIndexMap;

	protected List<UniIcon> ItemsCreated;

	[SerializeField]
	private UIEventListener btnCharge;

	[SerializeField]
	private UIEventListener btnAddCrystal;

	[SerializeField]
	private UIEventListener btnHomePage;

	[SerializeField]
	private UIEventListener btnLeft;

	[SerializeField]
	private UIEventListener btnRight;

	[SerializeField]
	private UIEventListener btnBuy;

	[SerializeField]
	private UIEventListener btnBuyGray;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UILabel lbCost;

	[SerializeField]
	private UILabel lbLeft;

	[SerializeField]
	private UILabel lbMid;

	[SerializeField]
	private UILabel lbRight;

	[SerializeField]
	private UILabel lbCostGray;

	[SerializeField]
	private GameObject objBuy;

	[SerializeField]
	private GameObject vipLeft;

	[SerializeField]
	private GameObject vipRight;

	public UpdateTimerUTC EndTimer;

	protected WeekVipGiftInfoProto StatusProto;

	protected WeekVipGiftInfoProto.ConfigProto ConfigProto;

	public UIGrid ItemGrid;

	public UIScrollView scrollView;

	protected override void DoInit()
	{
	}

	public void Update()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void BuyVipGift()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoClearData()
	{
	}

	public void BtnLeftClick()
	{
	}

	public void BtnRightClick()
	{
	}

	protected void RequestInfo()
	{
	}

	public void SetupConfig(WeekVipGiftInfoProto.ConfigProto configData)
	{
	}

	public void ClearItemGrid()
	{
	}

	public void SetupUI()
	{
	}
}
