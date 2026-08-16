using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardBaQi : IceUIBase
{
	[SerializeField]
	private UILabel CoinLabel;

	[SerializeField]
	private UILabel BaqiLabel;

	[SerializeField]
	private UIEventListener LvupBtn;

	[SerializeField]
	private UIEventListener ItemShowBtn;

	[SerializeField]
	private UIEventListener ProShowBtn;

	[SerializeField]
	private UICardBaQiItemListCtrller ItemPanel;

	[SerializeField]
	private UICardBaQiHeadCtrller HeadCtrller;

	[SerializeField]
	private IceAnimatorTotalCommander enableUpAnimator;

	[SerializeField]
	private IceAnimatorTotalCommander clickUpAnimator;

	[SerializeField]
	private IceAnimatorTotalCommander maxLevelAnimator;

	[SerializeField]
	private UIEventListener gmE;

	[SerializeField]
	private GameObject mouseMask;

	private int crystalCount;

	private bool isplaying;

	private Hero card;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void onGm(GameObject obj)
	{
	}

	private void loopRequest(List<CardBaQiItem> list)
	{
	}

	protected override void DoDispose()
	{
	}

	private void checkEnableUpAnim()
	{
	}

	private void OnLevelupClicked(GameObject obj)
	{
	}

	private void OnProShowClicked(GameObject obj)
	{
	}

	private void OnItemShowClicked(GameObject obj)
	{
	}

	protected override void DoClearData()
	{
	}

	public void Refrush()
	{
	}

	public void ResetData(Hero _card)
	{
	}

	private void clear()
	{
	}

	public void SetData(Hero data, bool _needRefreshAll = true)
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

	protected override void DoShowOffscreen()
	{
	}

	private void Update()
	{
	}
}
