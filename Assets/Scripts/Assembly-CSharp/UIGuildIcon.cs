using System;
using UnityEngine;

public class UIGuildIcon : IceUIBase
{
	public UISprite FG_Image;

	public UISprite Checkmark;

	public UIEventListener ItemButton;

	private int iconID;

	public Action<int> E_IconClicked;

	public void SetData(int iconID, bool isSelected)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void OnItemClicked(GameObject gameObj)
	{
	}
}
