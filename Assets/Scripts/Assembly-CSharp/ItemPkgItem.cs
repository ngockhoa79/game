using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemPkgItem : IceUIBase
{
	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public UILabel lbName;

	public UILabel lbDesc;

	public UILabel lbBuyCountRestToday;

	public UILabel lbBuyLimitTotal1;

	public UILabel lbBuyLimitTotal2;

	public GameObject goPromotion;

	public GameObject goHot;

	public GameObject goNew;

	public GameObject goItem;

	public GameObject goPackage;

	public GameObject goAlreadyBuy;

	public UIGrid gdPrice;

	public UILabel lb_1_Price;

	public UILabel lb_2PriceNow;

	public UILabel lb_2PriceOrgin;

	public GameObject goPriceGroup_1;

	public GameObject goPriceGroup_2;

	public UIEventListener eventDetail;

	public UIEventListener eventBuy;

	public UniIcon Icon;

	public GameObject[] CanBuyGameObjects;

	public GameObject[] CanNotBuyGameObjects;

	public Action<PkgItem, ItemPkgItem> E_OnDetail;

	public Action<PkgItem, ItemPkgItem> E_OnBuy;

	private PkgItem mData;

	private bool mEnable;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
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

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Clear()
	{
	}

	public void SetData(PkgItem data)
	{
	}
}
