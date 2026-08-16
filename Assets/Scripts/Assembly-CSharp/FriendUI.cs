using System;
using UnityEngine;

public class FriendUI : IceUIBase
{
	public IceUIBtnGroup TabButton;

	public IceUIBase[] TabPanels;

	private int mSelectedIndex;

	[HideInInspector]
	public int SubPanelToOpen;

	public UIEventListener EventBack;

	public UIEventListener EventMain;

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

	public void OnChangeTab(int oldIndex, int newIndex)
	{
	}
}
