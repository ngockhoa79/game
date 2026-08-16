using System;
using UnityEngine;

public class UIMakyouRoot : IceUIBase
{
	public UIEventListener ButtonHome;

	public UIEventListener ButtonBack;

	public IceUIBtnGroup ButtonsTab;

	public MakyouRegularSeasonController RegularPage;

	public MakyouPlayoffsController PlayoffsPage;

	public Action E_OnHome;

	public Action E_OnBack;

	public Action E_OnRegularPageButtonFight;

	public Action E_OnRegularPageRanklist;

	public Action E_OnRegularPageShop;

	public Action E_OnPlayoffsPageButtonArray;

	public Action E_OnPlayoffsPageButtonSupportRanklist;

	private int currentTabID;

	private string currentTabName;

	private int currentProgressDay;

	private double InitTimer;

	public void Update()
	{
	}

	public void SetData(int CurrentDay)
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

	protected override void DoDispose()
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
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

	public void RequestInfos()
	{
	}
}
