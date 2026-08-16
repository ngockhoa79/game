using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPVEEventRoot : IceUIBase
{
	private enum ChapterDropType
	{
		CONSUME = 1,
		CARD = 2,
		EQUIPMENT = 3,
		_NUM = 4
	}

	public UIPanel uiClipper;

	public UIGrid uiGrid;

	public bool isNeedBackButton;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	public Action<int> E_OnSelectChapter;

	private List<UIPVEEventGroup> _eventGroups;

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

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnSetChapters()
	{
	}

	private void OnLoadEventGroup(EventGroup data)
	{
	}

	private void OnSelectChapter(int chapterId)
	{
	}
}
