using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICmGearIcon : UICmItemIcon
{
	public UISprite defaultCover;

	public UILabel Name;

	public UILabel RefineLevel;

	public bool CanShowRedDot;

	public GameObject RedDot;

	public bool CanShowUpgrade;

	public GameObject UpgradeTip;

	protected override void Set(ItemHolding holding)
	{
	}

	protected override void Clear()
	{
	}
}
