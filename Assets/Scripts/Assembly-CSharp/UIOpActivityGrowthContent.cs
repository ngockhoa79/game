using System;
using UnityEngine;

public class UIOpActivityGrowthContent : IceUIBase
{
	private enum EState
	{
		Active = 0,
		Inactive = 1,
		Received = 2
	}

	[SerializeField]
	private GameObject activeRoot;

	[SerializeField]
	private GameObject inActiveRoot;

	[SerializeField]
	private GameObject received;

	[SerializeField]
	private UILabel lbLevelTitle;

	[SerializeField]
	private UILabel lbLevelContent;

	[SerializeField]
	private UILabel lbCrystal;

	[SerializeField]
	private UIEventListener eventGetReward;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	private UIOpActivityGrowthData _data;

	public Action<UIOpActivityGrowthData> E_OnClick;

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	public void SetData(UIOpActivityGrowthData data)
	{
	}

	public void Refresh()
	{
	}

	private void SetRewardActive(EState state)
	{
	}
}
