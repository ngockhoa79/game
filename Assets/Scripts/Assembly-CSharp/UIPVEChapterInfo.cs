using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIPVEChapterInfo : MonoBehaviour
{
	public UILabel lbChapterName;

	public UITexture txChapterView;

	public UILabel lbGold;

	public UILabel lbExp;

	public UILabel lbDescription;

	public UILabel lbConsumeEnergy;

	public UILabel lbRemainTimes;

	public UILabel lbStars;

	public UniIcon iconDrop1;

	public UniIcon iconDrop2;

	public UniIcon iconDrop3;

	public UIEventListener eventChapterInfo;

	public UIPVEChapterReport ChapterReport;

	public UIEventListener btnBattleStart;

	public UIEventListener btnSweep;

	public UIEventListener btnChapterBonus;

	public UIEventListener btnReport;

	public GameObject BonusPanel;

	public GameObject RecordPanel;

	public GameObject MissionInfoPanel;

	public GameObject ChapterInfoPanel;

	public UIPVEChapterBonusPage ChapterBonusPage;

	public UniIcon MissionBonusItem;

	public UILabel MissionTips;

	public UIEventListener btnTaskReward;

	public GameObject NotifyRedDot;

	public GameObject SweepNotifyRedDot;

	public IceAnimatorTotalCommander animAbleReward;

	public Action<bool> OnChapterBonusClick;

	[NonSerialized]
	public bool bActive;

	private int duplicationID;

	private int curChapterID;

	private string chapterViewName;

	private bool bonusFlag;

	private GameObject popupObj;

	private UIPVEDropTips popupUI;

	public SimpleItem taskBonusItem;

	public int PveCountLeft { get; private set; }

	public int PveDupEnergyReq { get; private set; }

	public bool IsBonusPanelOpen => false;

	private void OnDestroy()
	{
	}

	public void SetData(int duplicationId, int progressType)
	{
		PveCountLeft = 10;
		PveDupEnergyReq = 6;
		SetChapterView(duplicationId);
		SetMissionInfo();
	}

	private void RefreshRedDot()
	{
	}

	private void SetChapterView(int chapterID)
	{
		if (lbConsumeEnergy != null) lbConsumeEnergy.text = PveDupEnergyReq.ToString();
		if (lbRemainTimes != null) lbRemainTimes.text = PveCountLeft.ToString();
		RefreshRedDot();
	}

	public void OnCallRecordList()
	{
	}

	private void OnCallChapterBonusPage(GameObject obj)
	{
	}

	public void SwitchBonus2Info()
	{
	}

	public void SetMissionInfo()
	{
	}

	private void ShowHolding(int type, int id, int count)
	{
	}

	private void SetDrop(UniIcon view, CfgProtoDuplication.DropItemContent data)
	{
	}

	private void SpawnDropTips(string name, string config, string desc)
	{
	}

	private void OnDropTipsClosed()
	{
	}
}
