using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGearDisplayer : IceUIBase
{
	public UILabel GearLevel;

	public UILabel GearMajorBufValue;

	public UILuggagePortrait GearPortrait;

	[SerializeField]
	private UIEventListener SelectButton;

	[SerializeField]
	private GameObject UserRoot;

	[SerializeField]
	private UILabel UserTxt;

	public Action<ItemHolding> OnSelect;

	public ItemHolding gear { get; private set; }

	public void Awake()
	{
	}

	public void SetData(ItemHolding gear)
	{
	}

	private void setData(GearHolding holding)
	{
	}

	private void OnSelectClicked(GameObject obj)
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

	private string RarityStringColor(ERarity rarity)
	{
		return null;
	}
}
