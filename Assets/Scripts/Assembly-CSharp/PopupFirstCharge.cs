using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class PopupFirstCharge : IceUIBase
{
	public Action E_OnConfirm;

	[SerializeField]
	private UIEventListener btnConfirm;

	[SerializeField]
	private UITable table;

	[SerializeField]
	private UILabel lbTitle;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	public void SetData(int buyCrystal, List<ThingHolding> _firstPrizes, List<ThingHolding> _extraPrizes)
	{
	}

	public void SetMonth(int crystal)
	{
	}

	public void SetYear(int crystal)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void Reposition()
	{
	}
}
