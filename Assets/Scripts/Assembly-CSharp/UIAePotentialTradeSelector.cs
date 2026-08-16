using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAePotentialTradeSelector : IceUIBase
{
	public static Action<BattleArray, Hero, bool> OnFinished;

	public UIEventListener ReplaceBtn;

	private Hero card;

	private bool shouldNoneEvent;

	public int SlotIndex;

	public Hero Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsSelected => false;

	private void set(Hero card)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	public void RemoveTradeSelectorEvent()
	{
	}

	private void SetFerrers()
	{
	}

	private void handleReplaceBtnClicked(GameObject btn)
	{
	}

	private void unload()
	{
	}

	private void handleReturn()
	{
	}

	private void handle(List<ItemHolding> holdings)
	{
	}
}
