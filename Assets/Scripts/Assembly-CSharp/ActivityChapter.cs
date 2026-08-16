using System;
using System.Collections.Generic;
using Ice.ProjectCos.Config;

public class ActivityChapter
{
	private ActivityChapterTemplateExt mCfg;

	public int ChapterID => 0;

	public int CurLevelIndex { get; set; }

	public int CurLevelID => 0;

	public static int MaxBuyToday => 0;

	public int BuyTimesToday { get; set; }

	public List<ActivityLevel> Levels { get; set; }

	public string Name => null;

	public string OpenHint => null;

	public string InnerName => null;

	public int Position => 0;

	public string BG => null;

	public string EnemyHeader => null;

	public int ExpAward => 0;

	public int AwardType => 0;

	public int LimitChallageTimes => 0;

	public int UsedChallageTimes { get; set; }

	public int EnergyCost => 0;

	public DateTime TimeEnable { get; private set; }

	public DateTime TimeDisable { get; private set; }

	public int[] DaysOfWeekIntList { get; private set; }

	public int TimeOpenHour { get; private set; }

	public int TimeOpenMinute { get; private set; }

	public int TimeCloseHour { get; private set; }

	public int TimeCloseMinute { get; private set; }

	public DateTime TimeNextOpen { get; private set; }

	public DateTime TimeNextClose { get; private set; }

	public ActivityChapter(ActivityChapterTemplateExt cfg)
	{
	}

	public bool IsChallageTimeEnough()
	{
		return false;
	}

	public bool IsOpened()
	{
		return false;
	}

	public bool IsNotClosed()
	{
		return false;
	}

	public bool IsDayOfWeekOpen()
	{
		return false;
	}

	public bool IsNormalLevelEnable()
	{
		return false;
	}

	public bool IsHardLevelEnable()
	{
		return false;
	}

	public bool IsAcheronLevelEnable()
	{
		return false;
	}

	public void ActiveNextLevel(ActivityLevel actLv)
	{
	}

	public bool IsChapterTimeAvaible()
	{
		return false;
	}

	public bool IsChapterTimeOpen()
	{
		return false;
	}

	public bool IsChapterEnable()
	{
		return false;
	}

	public void GenateNextOpenTime()
	{
	}
}
