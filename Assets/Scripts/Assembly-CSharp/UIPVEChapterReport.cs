using System;
using UnityEngine;

public class UIPVEChapterReport : IceUIBase
{
	public UIScrollView uiRecordsList;

	public UIGrid uiGrid;

	public UIEventListener btnClose;

	[HideInInspector]
	public int duplicationID;

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void SetData()
	{
	}

	public void InitData()
	{
	}

	private void ClearList(Action callback)
	{
	}
}
