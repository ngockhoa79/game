using System;
using UnityEngine;

public class UIPVERecordReplay : IceUIBase
{
	public UIScrollView uiRecordsList;

	public UIGrid uiGrid;

	[HideInInspector]
	public int duplicationID;

	protected override void DoPrepare()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void InitData()
	{
	}

	private void ClearList()
	{
	}
}
