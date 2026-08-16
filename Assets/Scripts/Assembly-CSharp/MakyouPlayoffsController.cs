using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class MakyouPlayoffsController : MonoBehaviour
{
	public class MyBattleStructure
	{
		public CrossPersonPlayOffInfoProto.BattleOnceProto BattleData;

		public MakyouData.PlayoffsFightTimePoint NextRoundTimePoint;

		public bool DataIsFake;
	}

	public UIEventListener ButtonSupportList;

	public UIEventListener ButtonArrayEditor;

	public UIEventListener ButtonRefresh;

	public UIEventListener ButtonHelp;

	public UILabel NextDate;

	public UILabel Top2;

	public UILabel Top2_Time;

	public UILabel Top4;

	public UILabel Top4_Time;

	public UILabel Top8;

	public UILabel Top8_Time;

	public UILabel NextCombatTime_CountDown;

	public UILabel NextCombatTime_NextRound;

	public GameObject CountDownGroup;

	public UITexture ChampionHeadA;

	public UITexture ChampionHeadB;

	public MakyouPlayoffBattle[] Battles;

	public Action E_OnArrayEditor;

	public Action E_OnSupportRanklist;

	protected static readonly string TextColorRed;

	protected static readonly string TextColorWhite;

	private CrossPersonPlayOffInfoProto PlayoffData;

	private double CombatTimer;

	private double InitTimer;

	private bool ArrayEditable;

	private void Update()
	{
	}

	public void Setup()
	{
	}

	public void SetData()
	{
	}

	public void ResetUI()
	{
	}

	public void ClearData()
	{
	}

	public void Clear()
	{
	}

	public void SetupCalendar()
	{
	}

	public void RequestPlayoffData()
	{
	}

	public MyBattleStructure FindMyNextBattle()
	{
		return null;
	}

	public void OnCombatTimer()
	{
	}

	public void SetupNextTimer()
	{
	}

	public void RefreshUI()
	{
	}

	private void OnSupportListClicked(GameObject btn)
	{
	}

	private void OnArrayEditorClicked(GameObject btn)
	{
	}

	private void OnRefreshClicked(GameObject btn)
	{
	}

	private void OnHelpClicked(GameObject btn)
	{
	}
}
