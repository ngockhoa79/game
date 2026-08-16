using System;
using UnityEngine;

public class ContinueCharge : IceUIBase
{
	public UIEventListener btnHomePage;

	public UIEventListener[] Btns;

	public GameObject OpAcContent;

	private int BtnStatusNow;

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

	private void InitBtnStatus(GameObject obj)
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void GetInfo(int index)
	{
	}

	protected override void DoDispose()
	{
	}
}
