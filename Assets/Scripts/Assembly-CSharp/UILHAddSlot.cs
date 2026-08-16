using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILHAddSlot : IceUIBase
{
	public UniIcon ICON;

	public GameObject emptySlot;

	public UIEventListener button;

	public Action<int, ThingHolding> E_OnClicked;

	public ThingHolding mData;

	public int Index { get; set; }

	public void Start()
	{
	}

	public ThingHolding GetData()
	{
		return null;
	}

	public void SetData(ThingHolding item, int index)
	{
	}

	public void SetData(ThingHolding item)
	{
	}

	private void clear()
	{
	}
}
