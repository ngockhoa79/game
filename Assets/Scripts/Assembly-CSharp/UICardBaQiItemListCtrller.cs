using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQiItemListCtrller : IceUIBase
{
	public UICardBaQiItemCell[] ItemCells;

	[HideInInspector]
	public Action EquipCallBack;

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void UpdateItemListState(int start, int len, int state)
	{
	}

	public void SetData(Hero data)
	{
	}

	public void resetItemList()
	{
	}

	public void resetItemListAnima()
	{
	}

	public bool IsPassItemCheck()
	{
		return false;
	}
}
