using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

public class MakyouData
{
	public class AfterFightDataChange
	{
		public int PointChange;

		public int PreviousMakyouLevel;

		public int CurrentMakyouLevel;

		public bool IsWinner;
	}

	public class RegularFinishedReward
	{
		public int RewardDiamond;

		public int RewardBean;

		public List<ThingHolding> RewardItems;
	}

	public enum PlayoffsFightType
	{
		Fight8to4 = 0,
		Fight4to2 = 1,
		Fight2to1 = 2
	}

	public enum PlayoffsFightRound
	{
		Round1 = 1,
		Round2 = 2,
		Round3 = 3,
		Round4 = 4,
		Round5 = 5
	}

	public class PlayoffsFightTimePoint
	{
		public DateTime TimePoint;

		public PlayoffsFightType Type;

		public PlayoffsFightRound Round;

		public int PointIndex;

		public PlayoffsFightTimePoint(DateTime dateTime, PlayoffsFightType fight_type, PlayoffsFightRound fight_round, int point_index)
		{
		}

		public PlayoffsFightTimePoint(PlayoffsFightTimePoint copySource)
		{
		}
	}

	public class PlayerUID : IEquatable<PlayerUID>
	{
		private int ServerNo;

		private ulong PlayerID;

		public PlayerUID(int server_id, ulong player_id)
		{
		}

		public bool Equals(PlayerUID other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(PlayerUID uid1, PlayerUID uid2)
		{
			return false;
		}

		public static bool operator !=(PlayerUID uid1, PlayerUID uid2)
		{
			return false;
		}
	}

	public static readonly int SeasonDays;

	public static readonly int CombatCountEachBattle;

	public static readonly int MagicBeanID;

	public static string MyID;

	public static PlayerCrossPersonInfoProto CurrentInfo;

	public static CrossPersonSeasonInfoProto HistoryInfo;

	public static CrossPlayerSummaryInfoProto LastChampionInfo;

	public static CrossPersonSeasonInfoProto LatestSeasonSnap;

	public static bool LatestSeasonSnapDirty;

	public static CrossPersonPlayOffInfoProto PlayoffInfo;

	public static int RootUITab;

	public static AfterFightDataChange AfterFightData;

	public static RegularFinishedReward RegularRewards;

	public static List<PlayoffsFightTimePoint> PlayoffsTimePoints;

	public static List<bool>[] PlayoffsAnimationPlayed;

	public static Dictionary<PlayerUID, bool> PlayerLivingStatus;

	public static DateTime PlayoffsInitTime;

	public static TimeSpan MakyouRegularOpenTime => default(TimeSpan);

	public static TimeSpan MakyouRegularCloseTime => default(TimeSpan);

	public static void Clear()
	{
	}

	public static int GetProgressDay()
	{
		return 0;
	}

	public static void AnalyzePlayerLivingStatus()
	{
	}

	protected static bool Analyze(CrossPlayerSummaryInfoProto Player, int battleIndex)
	{
		return false;
	}

	public static void SetupTimeline()
	{
	}

	public static void ResetPlayoffsAnimationPlayedState()
	{
	}

	public static PlayoffsFightTimePoint GetTimePointJustPassedBy()
	{
		return null;
	}

	public static PlayoffsFightTimePoint GetTimePointComing()
	{
		return null;
	}

	public static PlayoffsFightTimePoint GetTimePointComing_NextType(int index)
	{
		return null;
	}

	private static DateTime GetEndTimeByStartTime(DateTime startTime)
	{
		return default(DateTime);
	}

	public static DateTime Get8to4StartTime()
	{
		return default(DateTime);
	}

	public static DateTime Get8to4EndTime()
	{
		return default(DateTime);
	}

	public static DateTime Get4to2StartTime()
	{
		return default(DateTime);
	}

	public static DateTime Get4to2EndTime()
	{
		return default(DateTime);
	}

	public static DateTime Get2to1StartTime()
	{
		return default(DateTime);
	}

	public static DateTime Get2to1EndTime()
	{
		return default(DateTime);
	}

	public static bool IsPlayerStillAlive(CrossPlayerSummaryInfoProto playerProto)
	{
		return false;
	}
}
