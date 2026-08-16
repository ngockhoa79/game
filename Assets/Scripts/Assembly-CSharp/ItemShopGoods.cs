using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemShopGoods : MonoBehaviour
{
	private UISprite sprite;

	public UILabel lbName;

	public UILabel lbPrice;

	public PayTypeIcon PayIcon;

	public UISprite spDisable;

	public UISprite spBG;

	public UIEventListener eventDetail;

	public UniIcon Icon;

	public Action<ShopItem, ItemShopGoods> E_OnDetail;

	private ShopItem mData;

	private bool mEnable;

	public UIDragScrollView Dragger;

	public void Start()
	{
	}

	public void Clear()
	{
	}

	public void SetData(ShopItem shopItem, ShopType shopType)
	{
	}

	public void SetStatueEnable(bool enable)
	{
	}

	private void setBGType(ShopType type)
	{
	}

	private void OnDetailClick(GameObject go)
	{
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void OnScroll(float delta)
	{
	}
}
