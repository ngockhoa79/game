using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICmSkillIcon : UICmItemIcon
{
	public UISprite defaultCover;

	public UILabel Name;

	public UISprite Slot;

	public bool CanShowRedDot;

	public GameObject RedDot;

	protected override void Set(ItemHolding holding)
	{
	}

	protected override void Set(AbstractItem item)
	{
	}

	protected override void Clear()
	{
	}
}
