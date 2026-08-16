using System;
using UnityEngine;

public class GuildRootCtrller : IceUIBase
{
	public UIEventListener ChatBtn;

	public UIEventListener RankBtn;

	public UIEventListener ManageBtn;

	public UIEventListener ShopBtn;

	public UIEventListener HomeBtn;

	public UIEventListener ReturnBtn;

	public IceUIBtnGroup bottomTab;

	public IceUIToggleButton guildPkButton;

	private int currentTabIndex;

	private string CurrentTab;

	public GameObject ContentNode;

	public GameObject InfoPage;

	public GameObject MissionPage;

	public GameObject BuildPage;

	public GameObject PartyPage;

	public GameObject SkillPage;

	public GameObject CrossPkPage;

	public void SetData(int _enterTab)
	{
	}

	public void RefreshUI()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetTab(int _tab)
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}

	private void ActiveTabUI(int _tab)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnChatBtnClicked(GameObject obj)
	{
	}

	private void OnRankBtnClicked(GameObject obj)
	{
	}

	private void OnManagerBtnClicked(GameObject obj)
	{
	}

	private void OnShopBtnClicked(GameObject obj)
	{
	}

	public void GotoGuildShop()
	{
	}

	private void refreshMissionPanel()
	{
	}

	private void spine(bool show)
	{
	}
}
