using System;
using UnityEngine;

public class UIAccSign : IceUIBase
{
	public UILabel Month;

	public UILabel Days;

	public UIEventListener CloseButton;

	public UIEventListener GetButton;

	public UIEventListener HelpButton;

	public GameObject GetButtonReal;

	public GameObject GetButtonGray;

	public UIScrollView ScrollView;

	public UIPanel ScrollViewPanel;

	public UIWidget ScrollContent;

	public UIAccSignPage ItemPage;

	public IceAnimatorTotalCommander anim_in;

	public Action E_OnAccSigned;

	protected int MonthCache;

	protected override void DoInit()
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

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void SetData()
	{
	}

	public void UpdateScrollPosition()
	{
	}

	public void RefreshDaysState()
	{
	}

	public void RefreshItemsState()
	{
	}

	public void RefreshGetButtonState()
	{
	}

	private void OnHelpClicked(GameObject obj)
	{
	}

	private void OnGetButtonClicked(GameObject obj)
	{
	}

	public void TotalRefresh()
	{
	}

	public void DailyRefresh()
	{
	}

	private void OnClose(GameObject btn)
	{
	}
}
