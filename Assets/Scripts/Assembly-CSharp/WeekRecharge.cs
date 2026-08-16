using System;
using UnityEngine;

public class WeekRecharge : IceUIBase
{
	public GameObject DayRewardListContent;

	public GameObject RewardContent;

	public UIEventListener btnCharge;

	public UIEventListener btnHomePage;

	public UILabel ActivityTime;

	private static DateTime _dtStart;

	public UpdateTimerUTC EndTimer;

	public static DateTime TimeStampToDateTime(string timeStamp)
	{
		return default(DateTime);
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void Reset()
	{
	}

	protected override void DoDispose()
	{
	}
}
