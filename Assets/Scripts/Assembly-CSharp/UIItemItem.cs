using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIItemItem : IceUIBase
{
	public UILabel ItemNumber;

	public UILuggagePortrait ItemPortrait;

	public Action<ItemHolding, bool> OnSelect;

	[SerializeField]
	private UIEventListener SelectButton;

	private bool isSelected;

	public ItemHolding item { get; private set; }

	public void SetData(ItemHolding item)
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

	private void OnSelectClicked(GameObject obj)
	{
	}
}
