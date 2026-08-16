using System;
using UnityEngine;

public class UICardSellEnsure : IceUIBase
{
	public UILabel LabelSell;

	public UILabel LabelTotalPrice;

	public UILabel LabelSellEnsure;

	public UIEventListener EnsureButton;

	public UIEventListener CancelButton;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	public Action OnEnsure;

	public Action OnCancel;

	public void SetData(int totalprice)
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

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void SetFucntion()
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}

	private void OnCancelClicked(GameObject obj)
	{
	}
}
