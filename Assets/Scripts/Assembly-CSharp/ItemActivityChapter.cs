using System;
using UnityEngine;

public class ItemActivityChapter : IceUIBase
{
	public UIEventListener eventGo;

	public UpdateTimerUTC Timer;

	public UISprite spAwardIcon;

	public UITexture txHeader;

	public GameObject Root;

	public UILabel lbLevelName;

	public UILabel lbOpenTime;

	public Action<ActivityChapter> E_OnGotoActive;

	private ActivityChapter mData;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public static string[] IconNames;

	protected override void DoInit()
	{
	}

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

	public ActivityChapter GetData()
	{
		return null;
	}

	public void SetData(ActivityChapter ac)
	{
	}

	public void setAwardIcon()
	{
	}

	public void setHeader()
	{
	}

	private void setTitle()
	{
	}
}
