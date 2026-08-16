using System;
using UnityEngine;

public class MakyouRegularSeasonController : MonoBehaviour
{
	public GameObject ChampionInfoGroup;

	public GameObject ChampionEmptyGroup;

	public UILabel ChampionName;

	public UIAeCardDisplayer ChampionHead;

	public UILabel ChampionLevel;

	public UILabel ChampionPower;

	public UISprite ChampionGuildIcon;

	public UILabel ChampionGuildName;

	public UILabel ChampionServer;

	public UILabel MakyouPoint;

	public UILabel MakyouRank;

	public UILabel WinRate;

	public UILabel ComboWin;

	public UILabel ChallengeWin;

	public UILabel ChallengeLose;

	public UILabel DefenseWin;

	public UILabel DefenseLose;

	public GameObject[] ActiveDays;

	public GameObject[] InactiveDays;

	public MakyouBadge BadgePrevious;

	public MakyouBadge BadgeCurrent;

	public MakyouBadge BadgeNext;

	public UISlider MakyouExpBar;

	public UILabel MakyouExpBarText;

	public GameObject LeftBottomPanel;

	public GameObject RightPanel;

	public UIEventListener ButtonFight;

	public UIEventListener ButtonHistory;

	public UIEventListener ButtonHelp;

	public UIEventListener ButtonRanklist;

	public UIEventListener ButtonShop;

	public Action E_OnButtonFight;

	public Action E_OnRankList;

	public Action E_OnShop;

	public void Setup()
	{
	}

	public void SetData(int CurrentDay)
	{
	}

	public void ClearData()
	{
	}

	public void Clear()
	{
	}

	public void SetProgress(int Day)
	{
	}

	public void OnButtonHistoryClick(GameObject btn)
	{
	}

	public void OnButtonHelpClick(GameObject btn)
	{
	}

	public void OnButtonFightClick(GameObject btn)
	{
	}

	public void OnButtonRanklistClick(GameObject btn)
	{
	}

	public void OnButtonShopClick(GameObject btn)
	{
	}
}
