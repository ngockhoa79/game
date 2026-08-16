using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public abstract class UIShopBase : IceUIBase, IceUIReusableList<ShopItemN>.IVisualizer
{
	public UIEventListener eventOutMain;

	public UIEventListener eventOutBack;

	public UIShopItem3Animator ShopList;

	protected Shop mShop;

	[HideInInspector]
	public ShopType ShopType;

	protected ShopItem mClickShopItem;

	protected ItemShopGoods mClickUIItem;

	private Vector3 mPanelPosStore;

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

	public void SetData(GameObject widget, ShopItemN data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public virtual void OnShopItemClick(ShopItem si, ItemShopGoods uiItem)
	{
	}

	public virtual void OnBuy(ShopItem si)
	{
	}

	protected void requestShopItemContent(Action onComplete = null)
	{
	}

	public abstract void SetUI(int value = 0);

	public abstract void OnOpenShop();

	public void SetList(Action onComplete = null)
	{
	}

	public static bool IsEnoughToBuy(ShopItem si, bool showMsg = true)
	{
		return false;
	}

	protected virtual void showBuyShopItemDialog(ShopItem si, ItemShopGoods uiItem)
	{
	}

	protected void closeBuyShopItemDialog()
	{
	}

	protected void gotoCharge()
	{
	}
}
