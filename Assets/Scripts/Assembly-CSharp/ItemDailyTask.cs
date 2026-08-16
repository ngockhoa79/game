using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemDailyTask : IceUIBase
{
	public UILabel lbTitle;

	public UILabel lbProgress;

	public UILabel lbDesc;

	public UILabel lbReward;

	public UIButton bnGetReward;

	public UIButton bnGo;

	public Transform IconPos;

	public UIGrid gdRewardList;

	public UISprite spBgDark;

	public UISprite spBgHigh;

	public UISprite spNoTime;

	private DailyTask mData;

	private List<ThingIconNumRewardFrame> mAwardIcons;

	public Action<ItemDailyTask, DailyTask> OnGoto;

	public Action<ItemDailyTask, DailyTask> OnGetReward;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void Clear()
	{
	}

	public void SetData(DailyTask dt)
	{
	}

	private void setIconAnimate()
	{
	}

	private void clearAwardIcon()
	{
	}

	private void addAwardIcon()
	{
	}

	public void OnGoClick()
	{
	}

	public void OnGetRewardClick()
	{
	}
}
