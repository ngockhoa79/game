using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class LuggageStrengthenEnsure : IceUIBase
{
	[SerializeField]
	private UICmItemIcon Icon;

	[SerializeField]
	private UILabel ItemName;

	[SerializeField]
	private UILabel ItemResult;

	[SerializeField]
	private UILabel PerLevel;

	[SerializeField]
	private UILabel NewLevel;

	[SerializeField]
	private UILabel PerValue;

	[SerializeField]
	private UILabel NewValue;

	[SerializeField]
	private UILabel Tips;

	[SerializeField]
	private UISprite ValueType;

	[SerializeField]
	private UISprite ValueName;

	[SerializeField]
	private UIEventListener CloseButton;

	public Action OnClose;

	public void SetData(GearHolding oldHolding, GearHolding newHolding)
	{
	}

	public void OnDisplayIcon()
	{
	}

	public void OnClosePanel()
	{
	}
}
