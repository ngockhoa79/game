using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIShopMistery : UIShopBase
{
	public UILabel lbGlod;

	public UILabel lbCrystal;

	public GameObject[] DiffcutyTag;

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

	public string OnGetMisteryTimeString(TimeSpan d)
	{
		return null;
	}

	public override void OnShopItemClick(ShopItem si, ItemShopGoods uiItem)
	{
	}

	public override void OnBuy(ShopItem si)
	{
	}

	public string OnGetFreeRefreshTimeString(TimeSpan d)
	{
		return null;
	}

	private void showGotoBattleDialog(int index)
	{
	}

	public bool CheckCanMisteryShopOpen()
	{
		return false;
	}

	public override void SetUI(int value = 0)
	{
	}

	public override void OnOpenShop()
	{
	}

	private void setDiffcutyTag()
	{
	}

	private void gotoChangeFormation()
	{
	}

	private void requestMisteryChallege()
	{
	}
}
