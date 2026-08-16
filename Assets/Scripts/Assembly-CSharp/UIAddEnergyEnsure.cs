using System;
using UnityEngine;

public class UIAddEnergyEnsure : IceUIBase
{
	public UILabel LabelBuy;

	public UILabel LabelCrystal;

	public UILabel LabelBuyEnsure;

	public UILabel LabelSimpleRefresh;

	public UILabel LabelTotalRefresh;

	public UILabel LabelRemain;

	public UIEventListener EnsureButton;

	public UIEventListener CancelButton;

	public Action OnEnsure;

	public Action OnCancel;

	private Timer activeTimer;

	public void SetData(int totalprice, int energy, int remainTimes, int totalTimes)
	{
	}

	private void OnActiveTimer(Timer self)
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}

	private void OnCancelClicked(GameObject obj)
	{
	}
}
