using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemAchive : IceUIBase
{
	public UILabel lbTitle;

	public UILabel lbProgress;

	public UILabel lbDesc;

	public UILabel lbReward;

	public UIButton bnGetReward;

	public UIButton bnGo;

	public UISprite spDoing;

	public UITexture txTaskIcon;

	public UIGrid gdRewardList;

	public Transform IconPos;

	private AchiveGroup mData;

	private List<ThingIconNumFrame> mAwardIcons;

	public Action<ItemAchive, AchiveGroup> OnGoto;

	public Action<ItemAchive, AchiveGroup> OnGetReward;

	public GameObject btnReWardEnabled;

	public GameObject btnReWardDislable;

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

	public void SetData(AchiveGroup aGroup)
	{
	}

	private void setIconAnimate(string iconName)
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
