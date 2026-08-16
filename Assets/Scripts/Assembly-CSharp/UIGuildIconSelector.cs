using System;
using UnityEngine;

public class UIGuildIconSelector : IceUIBase
{
	public UIEventListener closeButton;

	public UIGrid grid;

	public Action<int> E_IconChanged;

	protected UIGuildIcon[] guildIcons;

	protected int guildIconCount;

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

	private void ClosePanel()
	{
	}

	public void OnCloseClick(GameObject btn)
	{
	}

	public void OnIconClick(int iconID)
	{
	}

	public void RequestChangeIcon(int iconID)
	{
	}
}
