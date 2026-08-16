using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardItem : IceUIBase
{
	public UILabel CardLevelNumber;

	public UILabel CardPrice;

	public UILabel RefineLevel;

	public UICardHalfBodyPortrait CardPortrait;

	public GameObject goNewNotice;

	public GameObject spLocked;

	[SerializeField]
	private UIEventListener StrengthenButton;

	[SerializeField]
	private BoxCollider StrengthenCollider;

	[SerializeField]
	public IceUIToggleButton SelectCheckBox;

	[SerializeField]
	private GameObject SelectGroup;

	[SerializeField]
	private GameObject SellGroup;

	[SerializeField]
	private GameObject OnField;

	[SerializeField]
	private GameObject StarupEnable;

	[SerializeField]
	public UILabel CardID;

	[SerializeField]
	private BaQiIcon baqiIcon;

	public Action<Hero> OnStrengthen;

	public Action<Hero> OnVewHero;

	public Action<Hero, bool> OnSelect;

	public UIEventListener eventTotal;

	public UIDragScrollView Dragger;

	public IceUIToggleButton.EState sellStatus;

	private CardBagManager.UIStatus selfStatus;

	private bool inMultiSelector;

	public Hero hero { get; private set; }

	public void SetData(Hero hero, CardBagManager.UIStatus status, bool isinSelector)
	{
	}

	public void SetData(Hero hero, bool isinSelector)
	{
	}

	private void setData(Hero hero)
	{
	}

	public void DisableTag()
	{
	}

	private void SetNotifyRoddot()
	{
	}

	public void OnSwitchStatus(CardBagManager.UIStatus status)
	{
	}

	public void ShowSellGroup(bool _show)
	{
	}

	public void LoadPortrait()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnStrengthenClicked(GameObject obj)
	{
	}

	public void OnSelectClicked(GameObject obj)
	{
	}

	private void onCardLoad()
	{
	}

	private void OnClick(GameObject go)
	{
	}

	private void OnPress(GameObject go, bool pressed)
	{
	}

	private void OnDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnScroll(GameObject go, float delta)
	{
	}
}
