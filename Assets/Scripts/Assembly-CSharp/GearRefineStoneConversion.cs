using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearRefineStoneConversion : IceUIBase
{
	public UIEventListener ButtonConfirm;

	public UIGrid ItemsGrid;

	public UILabel StoneValue;

	private List<ItemHolding> myStoneItems;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetData(List<ItemHolding> itemList, int stoneCount)
	{
	}

	public void ClearIcons()
	{
	}

	public void AddIcon(ThingHolding h)
	{
	}

	public void OnClose(GameObject clickedButton)
	{
	}
}
