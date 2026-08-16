using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UILuckPrizeGold : IceUIBase
{
	[SerializeField]
	private UILuckPrizeRewardPop prizePop;

	[SerializeField]
	private UIEventListener prizeBtn;

	[SerializeField]
	private UIEventListener btnHome;

	[SerializeField]
	private UIEventListener lookRewardBtn;

	[SerializeField]
	private UILabel lbcount;

	[SerializeField]
	private UILabel lbReward;

	[SerializeField]
	private UpdateTimerUTC nextTimer;

	[SerializeField]
	private UpdateTimerUTC EndTimer;

	[SerializeField]
	private UISprite btnTxt;

	[SerializeField]
	private UISprite circleBg;

	[SerializeField]
	private UISprite clickSp;

	[SerializeField]
	private GameObject popTxt;

	[SerializeField]
	private GameObject text_viewObj;

	[SerializeField]
	private IceAnimatorTotalCommander newRewradAnimator;

	[SerializeField]
	private IceAnimatorTotalCommander totalRewardAnimator;

	private int cfgDayCount;

	private int cfgBaseDayCount;

	private int curCount;

	private bool timeend;

	private int totalCount;

	private List<ThingProto> rewardList;

	private GoddessGrailInfoProto.ConfigProto protoInfo;

	private GoddessGrailInfoProto info;

	protected override void DoInit()
	{
	}

	private void onHome(GameObject obj)
	{
	}

	private void onLookReward(GameObject obj)
	{
	}

	private void onPrize(GameObject obj)
	{
	}

	protected override void DoPrepare()
	{
	}

	private void resetCountTime(long time)
	{
	}

	private void resetCfgData(GoddessGrailInfoProto.ConfigProto data)
	{
	}

	private int getPrizeCount()
	{
		return 0;
	}

	private void setPrizeBtnEnable(bool b)
	{
	}

	private void resetUserData(GoddessGrailInfoProto data)
	{
	}

	private void refrushWindow(S2CGoddessGrailInfoAck ack)
	{
	}

	private void __sendInfoReq()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoDestroy()
	{
	}
}
