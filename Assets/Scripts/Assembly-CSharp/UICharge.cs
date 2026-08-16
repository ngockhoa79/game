using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICharge : IceUIBase, IceUIReusableList<ChargeItemN>.IVisualizer
{
	public UIEventListener eventVIP;

	public UIEventListener eventPackage;

	public UIEventListener eventOutMain;

	public UIEventListener eventOutBack;

	public UILabel lbMoney;

	public VipInfoCtrller VIPShow;

	public GameObject NextChargePart;

	public UIProgressBarCtrller PBVIPExp;

	public Transform[] FirstChargeAwardSlots;

	public UILabel[] lbFirstChargeAwardNames;

	public ChargeItemAnimator ChargeList;

	private ChargeList mChargeList;

	private ChargeInfo mBuying;

	private int lvBefore;

	private int lvAfter;

	private float pBefore;

	private float pAfter;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void OnCrystalChange(int value)
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, ChargeItemN data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void setTitle()
	{
	}

	public void LoadFirstBuyAward()
	{
	}

	public void RequestChargeInfo()
	{
	}

	private void showNoConnectionDialog()
	{
	}

	public void ClearListAnimateOut(Action onComplete)
	{
	}

	public void SetList()
	{
	}

	public void OnChargeBuy(ChargeInfo charge)
	{
	}

	private void mockBuySuccess(ChargeInfo charge)
	{
	}

	public void OnChargeSuccess(object msg, int msgId)
	{
	}

	private void animateProgress(int lvAfter, float pAfter)
	{
	}
}
