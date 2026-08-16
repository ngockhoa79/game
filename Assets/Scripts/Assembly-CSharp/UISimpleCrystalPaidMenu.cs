using System;
using UnityEngine;

public class UISimpleCrystalPaidMenu : IceUIBase
{
	public UILabel LabelBuy;

	public UILabel LabelBuyEnsure;

	public UIEventListener EnsureButton;

	public UIEventListener CancelButton;

	public Action OnEnsure;

	public Action OnCancel;

	public void SetData(string str1, string str2, int totalprice)
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
