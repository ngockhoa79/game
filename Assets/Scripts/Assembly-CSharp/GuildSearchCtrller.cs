using System;
using System.Collections.Generic;
using UnityEngine;

public class GuildSearchCtrller : IceUIBase
{
	private const int ItemEveryPage = 5;

	public GuildInfoDataCtrller InfoGroup;

	public GuildSearchListCtrller SearchListGroup;

	public UIInput SearchInput;

	public UIEventListener SearchBtn;

	public UIEventListener ShowAllBtn;

	public UIEventListener PreviousPageBtn;

	public UIEventListener NextPageBtn;

	public UILabel PageIndexLabel;

	public UIEventListener HomeBtn;

	public UIEventListener ReturnBtn;

	private List<GuildInfo> guildList;

	private int currentPage;

	private int maxCount;

	private int maxPage => 0;

	public void SetData(List<GuildInfo> _list, int _maxCount)
	{
	}

	private void RefreshUI()
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

	private void ShowInfoByIndex(int _index)
	{
	}

	private void OnSearchClicked(GameObject obj)
	{
	}

	private void OnShowAllClicked(GameObject obj)
	{
	}

	private void OnPreviousPageClicked(GameObject obj)
	{
	}

	private void OnNextPageClicked(GameObject obj)
	{
	}

	private void AskGuildList(int _pageIndex)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}
}
