using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UISweepMenu : IceUIBase
{
	public UILabel LabelTitle;

	public UILabel LabelTimes;

	public UILabel LabelTips;

	public UIEventListener SweepOnceButton;

	public UIEventListener SweepNTimesButton;

	public UIEventListener OnCloseButton;

	[HideInInspector]
	public List<DuplicateSettlementProto> Settlements;

	public Action<bool> OnResponsed;

	public Action<int> OnBuySweepTimes;

	public Action<int> OnBuyEnergy;

	private int DuplicationID;

	private int SweepTimes;

	private int chapterType;

	private int RemainSweepTimes;

	private int DupEnergy;

	public void OnActiveClick()
	{
	}

	private void OnSweepCall(int _sweepTimes)
	{
	}

	private void OnResponse(object response)
	{
	}

	private void OnSweepOnceClicked(GameObject go)
	{
	}

	private void OnSweepNTimesClicked(GameObject go)
	{
	}

	private void OnCloseClicked(GameObject go)
	{
	}

	public void SetData(int _duplicationID, int _chapterType, int remainSweepTimes, int sweepTimes, int dupEnergy)
	{
	}

	protected override void DoDispose()
	{
	}
}
