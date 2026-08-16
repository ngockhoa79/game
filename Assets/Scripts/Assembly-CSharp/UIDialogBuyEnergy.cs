using System;
using UnityEngine;

public class UIDialogBuyEnergy : MonoBehaviour
{
	public UILabel lbText1;

	public UILabel lbText1_2;

	public UILabel lbText2;

	public UILabel lbText3;

	public UILabel lbText4;

	public UILabel lbText5;

	public UIEventListener eventOk;

	public UIEventListener eventCancel;

	public UILabel lbNextEnergyTime;

	public UILabel lbAllEnergyTime;

	public Action E_OnOK;

	public Action E_OnCancel;

	public Action E_OnFail;

	private void Start()
	{
	}

	private void Destroy()
	{
	}

	private void Update()
	{
	}

	public void SetForEnergyBuy()
	{
	}

	public void BuyEnergy()
	{
	}

	public string OnTimerString(TimeSpan span)
	{
		return null;
	}
}
