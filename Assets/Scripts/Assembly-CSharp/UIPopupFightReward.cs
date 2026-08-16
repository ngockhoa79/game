using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPopupFightReward : IceUIBase
{
	public Action E_OnConfirm;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private UIPopupCard[] cards;

	[SerializeField]
	private UIEventListener btnConfirm;

	[SerializeField]
	private GameObject goNoselect;

	[SerializeField]
	private GameObject goSelect;

	private ThingHolding _select;

	private List<ThingHolding> _otherList;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void SetData(ThingHolding selected, ThingHolding other1, ThingHolding other2)
	{
	}

	private void SelectCard(UIPopupCard selected)
	{
	}
}
