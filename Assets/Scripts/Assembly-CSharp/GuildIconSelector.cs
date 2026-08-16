using System;
using System.Collections.Generic;
using UnityEngine;

public class GuildIconSelector : IceUIBase
{
	[SerializeField]
	private UIEventListener btnClose;

	[SerializeField]
	private int deltaX;

	[SerializeField]
	private int deltaY;

	[SerializeField]
	private Transform firstIconPosition;

	[SerializeField]
	private Transform iconRoot;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	public Action E_OnClose;

	public Action<int> E_OnSelect;

	private bool bInitIcons;

	private List<GuildIcon> _allicons;

	private GuildIcon _selectedIcon;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetData(int defaultIndex)
	{
	}

	private void _initialize_icons_(int defaultIndex)
	{
	}
}
