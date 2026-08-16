using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIMakyouSelectOpponent : IceUIBase
{
	public UISprite RankIcon;

	public UILabel ComboWin;

	public UILabel MakyouPoint;

	public UILabel MakyouRank;

	public UILabel FightPower;

	public UILabel ChallengeTimesLeft;

	public UIEventListener ButtonHome;

	public UIEventListener ButtonBack;

	public UIEventListener ButtonReport;

	public UIEventListener ButtonRefresh;

	public UIEventListener ButtonBuyCount;

	public GameObject RefreshReadyGroup;

	public GameObject RefreshInCDGroup;

	public UILabel RefreshCDTime;

	public UILabel RefreshPrice;

	public int OpponentCount;

	public UIMakyouOpponent[] Opponents;

	public Action E_OnHome;

	public Action E_OnBack;

	public Action E_OnBattleReport;

	private List<CrossPersonTargetInfoProto> OpponentsData;

	private double CDTimeForRefresh;

	private int ResetCDPrice;

	private int BuyCountPrice;

	private double InitTimer;

	public void Update()
	{
	}

	public void SetData(List<CrossPersonTargetInfoProto> proto, double cdTime = -1.0)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	public void EnterScene()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void OnBackClicked(GameObject obj)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnReportClicked(GameObject obj)
	{
	}

	private void OnRefreshClicked(GameObject obj)
	{
	}

	private void OnBuyCountClicked(GameObject obj)
	{
	}

	private void ShowBuyCountDialog()
	{
	}

	private void OnResetCDConfirm()
	{
	}

	private void OnBuyCountConfirm()
	{
	}

	private void OnCDTimeEnd()
	{
	}

	protected override void DoDispose()
	{
	}

	public void ShowPopups()
	{
	}

	public void SetupTimer()
	{
	}

	public void OnInitTimer()
	{
	}
}
