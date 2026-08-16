using System;
using UnityEngine;

public class ActivityDayRecharge : IceUIBase
{
	public GameObject DayRewardListContent;

	public GameObject RewardContent;

	public UIEventListener btnCharge;

	public UIEventListener btnHomePage;

	public UpdateTimerUTC EndTimer;

	private static DateTime _dtStart;

	protected override void DoInit()
	{
	}

	public static DateTime TimeStampToDateTime(string timeStamp)
	{
		return default(DateTime);
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoDispose()
	{
	}
}
