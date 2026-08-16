using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIActivityPopup : IceUIBase
{
	public UIEventListener eventChallage;

	public UIEventListener eventBuy;

	public UIEventListener eventClose;

	public UIButton bnChallage;

	public Action E_Buy;

	public Action E_Close;

	public Action<ActivityLevel, int> E_Challage;

	public UILabel lbName;

	public UILabel lbBattleValue;

	public UILabel lbExpAward;

	public UILabel lbRestTime;

	public UILabel lbEneryCost;

	public GameObject NormalLcok;

	public GameObject NormalLevel;

	public GameObject HardLcok;

	public GameObject HardLevel;

	public GameObject AcheronLock;

	public GameObject AcheronLevel;

	public UIGrid gdAward;

	public IceUIBtnGroup TabDifficty;

	public UILabel lbOpenLv1;

	public UILabel lbOpenLv1_2;

	public UILabel lbOpenLv2;

	public UILabel lbOpenLv2_2;

	public UILabel lbOpenLv3;

	public UILabel lbOpenLv3_2;

	public UILabel lbOpenLv4;

	public UILabel lbOpenLv4_2;

	private ActivityChapter mData;

	private int mCurLevelIndex;

	private ActivityLevel mLevel;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	public void Start()
	{
	}

	public void OnTabChange(int oldIdx, int newIdx)
	{
	}

	public void SetData(ActivityChapter ac)
	{
	}

	public void SetLevelByIndex(int levelIndex)
	{
	}

	private void AddIcons(List<ThingHolding> list)
	{
	}
}
