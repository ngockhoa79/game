using System;
using UnityEngine;

public class UIGuildManagement : IceUIBase
{
	public UIEventListener closeButton;

	public UIEventListener ButtonActivities;

	public UIEventListener ButtonApplications;

	public UIEventListener ButtonSettings;

	public UIEventListener ButtonRecruit;

	public UIEventListener ButtonQuit;

	public UILabel RecruitPrice;

	public Action E_OnInfoChange;

	public Action E_GuildQuit;

	public Action E_OnCloseUI;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void ClosePanel()
	{
	}

	public void OnCloseClick(GameObject go)
	{
	}

	public void OnButtonActivitiesClick(GameObject go)
	{
	}

	public void OnButtonApplicationsClick(GameObject go)
	{
	}

	public void OnButtonSettingsClick(GameObject go)
	{
	}

	public void OnButtonRecruitClick(GameObject go)
	{
	}

	public void RequestRecruit()
	{
	}

	public void OnButtonQuitClick(GameObject go)
	{
	}

	public void RequestQuit()
	{
	}
}
