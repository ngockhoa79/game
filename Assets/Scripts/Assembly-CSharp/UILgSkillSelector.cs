using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILgSkillSelector : IceUITabView, IceUIReusableList<ItemHolding>.IVisualizer
{
	private string _filterName;

	public UIEventListener HomePageButton;

	public UIEventListener ReturnButton;

	public int SlotIndex;

	private readonly List<SkillHolding> candidates;

	public event Action<SkillHolding> OnSelect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnHomePage
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnReturn
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, ItemHolding item)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void Add(SkillHolding candidate)
	{
	}

	private List<SkillHolding> filter(string filter)
	{
		return null;
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void OnViewFunction(string filterName, IceUIBase view)
	{
	}
}
