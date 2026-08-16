using System.Collections.Generic;
using UnityEngine;

public class UIGearStoneExchange : IceUIBase
{
	[SerializeField]
	private List<UICmItemIcon> ReplaceStones;

	[SerializeField]
	private List<UILabel> ReplaceStonesNumber;

	[SerializeField]
	private UILabel lblTips;

	public UIEventListener ExchangeButton;

	public UIEventListener CloseButton;

	public void SetData()
	{
	}

	public void Clear()
	{
	}

	private void OnUseConsumeStoneClicked(GameObject obj)
	{
	}
}
