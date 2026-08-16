using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGearFragmentItem : IceUIBase
{
	public UILabel GearName;

	public UILabel GearChip;

	public UILabel GearChipNumber;

	public UILuggagePortrait GearPortrait;

	public UISprite CanForgeImg;

	[SerializeField]
	private UIEventListener ForgeButton;

	public Action<ItemHolding> OnForge;

	private bool canForge;

	public ItemHolding gearfragment { get; private set; }

	public void SetData(ItemHolding gearfragment)
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

	private void OnForgeClicked(GameObject obj)
	{
	}
}
