using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIShowCard : IceUIBase
{
	public Action E_OnEnd;

	public UIShowCardSingle SingleShow;

	public UIShowCardMuti MutiShow;

	public UIItemShow ShowItemUI;

	public UIShowCardBgAnimate BGAnimator;

	private UIShowCardButton BtnCtrol;

	public UIShowCardButton BtnCtrolSingle;

	public UIShowCardButton BtnCtrolNormal;

	public GameObject[] SubUIPart;

	public Action<UIShowCard> E_OnPreLoadComplete;

	private ShowIterator mShowIterator;

	private ItemHolding mShowing;

	private ProcedureManchine mProceduceMutiCard;

	private ProcedureLine mMuti1by1ShowLine;

	private ProcedureLine mMuti10ShowLine;

	[HideInInspector]
	public List<ItemHolding> ItemToShow { get; set; }

	[HideInInspector]
	public bool IsShowModeOnly { get; set; }

	private void Update()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	private void bindEvent()
	{
	}

	private void bindSubUIEvnet()
	{
	}

	private void PreCallbackOrBegin()
	{
	}

	private void PreChooseToShow()
	{
	}

	private void ChooseToShow(List<ItemHolding> listH)
	{
	}

	public void BeginShow()
	{
	}

	private void showItemOne(ItemHolding itemH)
	{
	}

	private void begin1By1Show(List<ItemHolding> listH)
	{
	}

	private void disableAllSubUI()
	{
	}

	private void showOnlyItemPart()
	{
	}

	private void showOnlySingleCardPart()
	{
	}

	private void showOnlyMutiCardPart()
	{
	}

	private void clearShowStep()
	{
	}

	private void EndAndBack()
	{
	}

	public void ClearAll()
	{
	}

	public void CreateProcedure()
	{
	}

	private void loopAction1(ItemHolding holding)
	{
	}

	private void loopActionOne(ItemHolding holding)
	{
	}

	private void loopActionFor10Card(ItemHolding holding)
	{
	}

	private void onLoopEnd()
	{
	}

	private void stepComplete()
	{
	}

	private void stepError()
	{
	}

	private void buttonHide()
	{
	}

	private void buttonPosNormal()
	{
	}

	private void buttonPosSingle()
	{
	}
}
