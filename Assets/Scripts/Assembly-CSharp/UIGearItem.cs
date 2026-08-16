using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGearItem : IceUIBase
{
	public UILabel GearLevel;

	public UILabel GearMajorBufValue;

	public UILabel GearPrice;

	public UILabel RefineLevel;

	public UILuggagePortrait GearPortrait;

	[SerializeField]
	private UIEventListener StrengthenButton;

	[SerializeField]
	private IceUIToggleButton SelectCheckBox;

	[SerializeField]
	private GameObject SelectGroup;

	[SerializeField]
	private GameObject SellGroup;

	[SerializeField]
	private GameObject UserRoot;

	[SerializeField]
	private GameObject Displayer;

	[SerializeField]
	private UILabel UserTxt;

	[SerializeField]
	private UIEventListener UnloadButton;

	[SerializeField]
	private GameObject goNewNotice;

	public Action<ItemHolding, bool> OnSelect;

	public Action<ItemHolding> OnStrengthen;

	public Action<ItemHolding> OnUnload;

	public GearHolding gearholding;

	public IceUIToggleButton.EState sellStatus;

	private CardBagManager.UIStatus selfStatus;

	private bool inMultiSelector;

	public ItemHolding gear { get; private set; }

	public void SetData(ItemHolding gear, CardBagManager.UIStatus status, bool isinSelector)
	{
	}

	public void SetData(ItemHolding gear, bool isinSelector)
	{
	}

	public void ShowSellGroup(bool bShow)
	{
	}

	private void SetNotifyRoddot()
	{
	}

	public void SetUnloadButton()
	{
	}

	private void OnUnloadClicked(ItemHolding holding)
	{
	}

	private void setData(GearHolding holding)
	{
	}

	private void fixOwnerDisplay(GearHolding holding)
	{
	}

	private void displayName(HeroConfig hc)
	{
	}

	private void errorLog()
	{
	}

	public void OnSelectClicked(GameObject obj)
	{
	}

	private void OnStrengthenClicked(GameObject obj)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void OnSwitchStatus(CardBagManager.UIStatus status)
	{
	}

	private string RarityStringColor(ERarity rarity)
	{
		return null;
	}
}
