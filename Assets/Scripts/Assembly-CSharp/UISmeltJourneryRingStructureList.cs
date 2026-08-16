using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UISmeltJourneryRingStructureList : IceUIBase
{
	private const string Res = "uismeltjournery";

	private const string Prefab = "RingStructureListItem";

	public IceUIBtnGroup Tabs;

	public GameObject[] TabViews;

	public UIEventListener CloseBtn;

	public UIEventListener HelpBtn;

	public Action OnClose;

	public UITable Host;

	public UITable Master;

	public UILabel LblUpdateTime;

	private void clear()
	{
	}

	protected override void DoInit()
	{
	}

	public void SetDetail(TrialChallengeWinningProto info)
	{
	}

	private string patchNameWithShadow(TrialWinningStageProto proto)
	{
		return null;
	}

	private string getRateString(int winC, int challengeC)
	{
		return null;
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
