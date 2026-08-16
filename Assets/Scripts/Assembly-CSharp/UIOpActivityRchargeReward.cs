using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIOpActivityRchargeReward : IceUIBase
{
	private enum ButtonStatus
	{
		Enabled = 0,
		Disabled = 1,
		Used = 2,
		GetAll = 3
	}

	[SerializeField]
	private UIEventListener btnGet;

	[SerializeField]
	private UIEventListener btnCharge;

	[SerializeField]
	private UIEventListener btnHomePage;

	[SerializeField]
	private UIEventListener btnHelp;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UILabel lbInfo;

	[SerializeField]
	private UILabel lbTotalInfo;

	[SerializeField]
	private GameObject btnGetGray;

	[SerializeField]
	private GameObject txtAllRight;

	[SerializeField]
	private GameObject txtUsed;

	[SerializeField]
	private UISprite progressBg;

	[SerializeField]
	private UISprite progressLight;

	[SerializeField]
	private UISprite spLeft;

	[SerializeField]
	private UISprite spRight;

	[SerializeField]
	protected UnityEngine.Object scaleResource;

	[SerializeField]
	protected GameObject scalesGameobj;

	[SerializeField]
	protected UITable rewardTable;

	[SerializeField]
	protected UpdateTimerUTC EndTimer;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	private List<ExpenseInfoProto.ConfigProto.Slot> list;

	private int indexMark;

	private int totalCount;

	private int rewardIndex;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	public void DoForeground()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	private void initScale()
	{
	}

	private void SetButtonStatus(ButtonStatus status)
	{
	}

	protected void ScaleClicked(int index)
	{
	}

	private void BindRewards(List<ThingProto> rewards)
	{
	}

	private void Refresh()
	{
	}

	private void _send_info_op()
	{
	}

	private void GetReward()
	{
	}
}
