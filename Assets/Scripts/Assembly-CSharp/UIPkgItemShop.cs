using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPkgItemShop : IceUIBase, IceUIReusableList<PkgItem>.IVisualizer
{
	[HideInInspector]
	public C2SDiamondShopBuyReq.TypeEnum OpenShopType;

	public PkgItemShopAnimator ShopList;

	protected PackageItemShop mUsingShop;

	public UILabel lbCrystal;

	private Vector3 mPanelPosStore;

	private void Start()
	{
	}

	private void Update()
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

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public virtual string OnGetItemName()
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, PkgItem data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void SetUI(int v = 0)
	{
	}

	public void OpenShop()
	{
	}

	private void listExit(Action onComplete)
	{
	}

	private void listEnter()
	{
	}

	public void RequestList(Action onComplete)
	{
	}

	public virtual void OnPackageDetail(PkgItem data, ItemPkgItem uiItem)
	{
	}

	public virtual void OnItemDetail(PkgItem data, ItemPkgItem uiItem)
	{
	}

	public virtual void OnBuyPackage(PkgItem data, ItemPkgItem uiItem)
	{
	}

	public virtual void OnBuyItem(PkgItem data, ItemPkgItem uiItem)
	{
	}

	private void buyItem(PkgItem data, ItemPkgItem uiItem, int buyCout = 1)
	{
	}

	private void OnBuyAwardClose(List<ThingHolding> list, PkgItem data, ItemPkgItem uiItem)
	{
	}

	private void refreshAfterBuy(PkgItem data, ItemPkgItem uiItem)
	{
	}

	private void showPackagePreviewDialog(PkgItem data, ItemPkgItem uiItem)
	{
	}

	private void showItemDetailDialog(PkgItem data, ItemPkgItem uiItem)
	{
	}

	private void showItemDetailDialogFromPackgePreview(ItemHolding showItem, PkgItem data, ItemPkgItem uiItem)
	{
	}

	private void showBuyPackageDialog(PkgItem data, ItemPkgItem uiItem)
	{
	}

	private void showItemBuyDialog(PkgItem data, ItemPkgItem uiItem)
	{
	}
}
