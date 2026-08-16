using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIShowCardButton : MonoBehaviour
{
	public GameObject BtnGroupSingle;

	public GameObject BtnGroupTwo;

	public UIEventListener evOK;

	public UIEventListener evOK2;

	public UIEventListener evAgain;

	public UIEventListener evAgain10;

	public UICostDisplayer CostReDraw;

	public Action E_OnAgainDraw;

	public Action E_OnAgainDraw10;

	public Action E_OnOk;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void bindEvent()
	{
	}

	public void ShowDrawAgainCost(C2SHeroLotteryReq.LotteryType drawCardType)
	{
	}

	public void SetCardButtonModel(bool IsTryAgainShow, bool isDraw10Time)
	{
	}

	public void HideButtons()
	{
	}
}
