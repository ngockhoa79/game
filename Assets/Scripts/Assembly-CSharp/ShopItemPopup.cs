using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ShopItemPopup : MonoBehaviour
{
	public UILabel lbName;

	public UILabel lbNum;

	public UILabel lbDesc;

	public UILabel lbPrice;

	public UILabel lbHechengNum;

	public UISprite spPayType;

	public UIEventListener eventBuy;

	public UIEventListener eventCancel;

	public UIEventListener eventCancelClose;

	public UniIcon Icon;

	public GearProperty GearProperty;

	public GameObject PartHecheng;

	private ShopItem mData;

	private AbstractItem mCfg;

	private ItemHolding mHolding;

	public Action<ShopItem> E_OnBuy;

	public Action<ShopItem> E_OnCancel;

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetData(ShopItem shopItem)
	{
	}

	public void SetData(PkgItem pkgItem)
	{
	}

	public void SetData(ItemHolding itemHolding)
	{
	}

	private void setByConfig()
	{
	}

	public void ShowPackage(PkgItem pkgItem)
	{
	}
}
