using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UISkillItem : IceUIBase
{
	public UILabel SkillPrice;

	public UILuggagePortrait SkillPortrait;

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

	[SerializeField]
	private GameObject goTagUpgrade;

	public Action<ItemHolding, bool> OnSelect;

	public Action<ItemHolding> OnStrengthen;

	public Action<ItemHolding> OnUnload;

	public IceUIToggleButton.EState sellStatus;

	private CardBagManager.UIStatus selfStatus;

	private bool inMultiSelector;

	public ItemHolding skill { get; private set; }

	public void SetData(ItemHolding skill, CardBagManager.UIStatus status, bool isinSelector)
	{
	}

	public void SetData(ItemHolding skill, bool isinSelector)
	{
	}

	public void ShowSellTag(bool bShowSellTag)
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

	private void setData(ItemHolding skill)
	{
	}

	private void fixOwnerDisplay(SkillHolding holding)
	{
	}

	private void displayName(HeroConfig hc)
	{
	}

	private void errorLog()
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

	private void OnStrengthenClicked(GameObject obj)
	{
	}

	private void OnSelectClicked(GameObject obj)
	{
	}

	private string RarityStringColor(ERarity rarity)
	{
		return null;
	}

	public void ShowTag(bool bShowUpgrade)
	{
	}
}
