using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardWakeup : IceUIBase
{
	[SerializeField]
	private UILabel CoinLabel;

	[SerializeField]
	private UICardWakeupHeadCtrller LeftHeadCtrller;

	[SerializeField]
	private UICardWakeupHeadCtrller RightHeadCtrller;

	[SerializeField]
	private UICardWakeupDataCtrller DataCtrller;

	[SerializeField]
	private UICardWakeupMatGroupCtrller MatGroupCtrller;

	[SerializeField]
	private GameObject ConsumeIcon;

	[SerializeField]
	private UILabel ConsumeLabel;

	[SerializeField]
	private UIEventListener WakeupBtn;

	[SerializeField]
	private UICardWakeupResultPanelCtrller ResultPanel;

	[SerializeField]
	private IceAnimatorTotalCommander PickCardAnim;

	[SerializeField]
	private IceAnimatorTotalCommander ActiveBtnAnim;

	[SerializeField]
	private IceAnimatorTotalCommander WakeupResultAnim;

	private Hero card;

	private int HeroLocalID;

	private HeroBreakTemplate herobreak;

	private int materialCount;

	private int coinCounter;

	private bool IsIllegalState => false;

	private bool CanWakeup => false;

	protected override void DoPrepare()
	{
	}

	public void ResetData(Hero _card)
	{
	}

	public void SetData(Hero _card, bool _needRefreshAll = true)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	private void Update()
	{
	}

	public void ShowAvatar(bool _show)
	{
	}

	private void OnWakeupClicked(GameObject obj)
	{
	}

	private void OnWakeupResponse(object response)
	{
	}

	private void EnsureWakeupResult()
	{
	}
}
