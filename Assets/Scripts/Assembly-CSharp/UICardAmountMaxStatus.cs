using System;
using UnityEngine;

public class UICardAmountMaxStatus : IceUIBase
{
	[SerializeField]
	private UILabel LblDesc;

	[SerializeField]
	private UILabel LblTips;

	[SerializeField]
	private UIEventListener CardLevelupButton;

	[SerializeField]
	private UIEventListener CardDecomposeButton;

	[SerializeField]
	private UIEventListener CardSellButton;

	[SerializeField]
	private UIEventListener AddCardSlotButton;

	public Action OnClose;

	public void SetData()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnLevelupClicked(GameObject obj)
	{
	}

	private void OnDecomposeClicked(GameObject obj)
	{
	}

	private void OnSellClicked(GameObject obj)
	{
	}

	private void OnAddCardSlotClicked(GameObject obj)
	{
	}
}
