using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UISmeltJourneryBattleReport : IceUIBase
{
	private const string Res = "uismeltjournery";

	private const string Prefab = "BattleReportItem";

	public UIEventListener HomeBtn;

	public UIEventListener BackBtn;

	public UIEventListener RulesBtn;

	public UIEventListener RankBtn;

	public UIEventListener BattleReportBtn;

	public Action OnHome;

	public Action OnBack;

	public Action OnRules;

	public Action OnRank;

	public Action OnBattleReport;

	public IceUIBtnGroup Tabs;

	public GameObject[] TabViews;

	public UIGrid gridSupport;

	public UIGrid gridNormal;

	public UIGrid gridSuper;

	public GameObject ManitoInfo;

	public GameObject HoodsInfo;

	protected override void DoInit()
	{
	}

	public void SetDetail(C2STrialBattleReportAck ack)
	{
	}

	private void createList(List<TrialBattleReporProto.ReporItemProto> reports, Transform parent, C2STrialReportDetailReq.TypeEnum t)
	{
	}

	private void handleTabSwitched(string oldTab, string newTab)
	{
	}

	private void activateTab(string tab, bool active)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}
}
