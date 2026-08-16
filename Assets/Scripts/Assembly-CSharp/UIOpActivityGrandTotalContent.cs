using System;
using UnityEngine;

public class UIOpActivityGrandTotalContent : IceUIBase
{
	private enum EState
	{
		Active = 0,
		Inactive = 1,
		Received = 2
	}

	[SerializeField]
	private GameObject btnGetGray;

	[SerializeField]
	private GameObject getUsed;

	[SerializeField]
	private UILabel lbTitleInfo;

	[SerializeField]
	private UILabel lbExInfo;

	[SerializeField]
	private UILabel lbGold;

	[SerializeField]
	private UIEventListener eventGet;

	[SerializeField]
	private UIGrid rewardList;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	public Action<UIOpActivityGrandTotalData> E_OnClick;

	private UIOpActivityGrandTotalData _data;

	public void SetData(UIOpActivityGrandTotalData data)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void Refresh()
	{
	}

	protected override void DoClearData()
	{
	}

	private void SetRewardActive(EState state)
	{
	}
}
