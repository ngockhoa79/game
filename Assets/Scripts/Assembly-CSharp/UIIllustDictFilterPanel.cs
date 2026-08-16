using System;
using UnityEngine;

public class UIIllustDictFilterPanel : IceUIBase
{
	public enum FilterCategory
	{
		Coser = 1,
		Gear = 7,
		Skill = 13
	}

	public UIEventListener closeButton;

	public IllustDictFilterButton[] FilterButtons;

	public Action<IllustDictBaseController.Filter> OnFilterSelected;

	public static readonly int FilterCount;

	private FilterCategory FilterCat;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void OnClose(GameObject btn)
	{
	}

	private void OnFilterButtonClicked(GameObject btn)
	{
	}

	public void SetFilterCategory(FilterCategory filter_cat)
	{
	}
}
