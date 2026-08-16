using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

public class SmeltJourney
{
	private static int coin;

	private static int boughtTimes;

	private static TrialInfoProto trialInfo;

	private static List<TrialForamtionProto> manitoHistory;

	private static List<TrialForamtionProto> hoodsHistory;

	public static int ContentNumber;

	private static int ColumnAmount;

	private static bool mineFirstColumnOccupied;

	private static List<ColumnInfo> inPositions;

	private static List<ColumnInfo> backups;

	private static List<int> onBoardIndexList;

	private static List<ItemChangeProto> changes;

	private static List<string> superStageNames;

	private static List<string> stageNames;

	private static DateTime mEnterTime;

	public static bool IsBattleWin { get; set; }

	public static List<ColumnInfo> InPositions => null;

	public static List<ColumnInfo> Backups => null;

	public static List<ItemChangeProto> Changes => null;

	public static bool IsRecordExists { get; set; }

	public static int MyArrayCount { get; set; }

	public static int Coin
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int BoughtTimes => 0;

	public static bool IsTimeOver => false;

	public static TrialInfoProto TrialInfo => null;

	public static List<TrialForamtionProto> ManitoHistory => null;

	public static List<TrialForamtionProto> HoodsHistory => null;

	public static int HoodsRange => 0;

	public static int HoodsIndex => 0;

	public static int AvailableColumns => 0;

	public static bool IsMineLastColumnOnBoard => false;

	public static void ClearAll()
	{
	}

	public static void SetChanges(List<ItemChangeProto> whatyougot)
	{
	}

	public static void SetAll(S2CTrialInfoAck ack)
	{
	}

	public static void AddBoughtTimeOnce()
	{
	}

	public static void EarnCoin(int delta)
	{
	}

	private static void updatePlayerInfo()
	{
	}

	public static bool CostCoin(int delta)
	{
		return false;
	}

	public static void SetTrialInfoProto(TrialInfoProto info, bool isManito)
	{
	}

	private static void patchNameWithShadow()
	{
	}

	public static void SetManitoHistory(List<TrialForamtionProto> pList)
	{
	}

	public static void AddManitoHistory(TrialForamtionProto p)
	{
	}

	public static void SetHoodsHistory(List<TrialForamtionProto> pList)
	{
	}

	public static void AddHoodsHistory(TrialForamtionProto p)
	{
	}

	public static List<BattleArray> GetFormationsArrays(List<TrialForamtionProto> proto)
	{
		return null;
	}

	public static BattleArray GetFormationArray(BattleFormationProto f, bool duplicateMe = false)
	{
		return null;
	}

	public static List<Hero> GetFormationsLeaders(List<TrialForamtionProto> proto)
	{
		return null;
	}

	public static Hero GetFormationLeader(BattleFormationProto f)
	{
		return null;
	}

	public static void Init()
	{
	}

	private static void addBackups(List<TrialForamtionProto> proto, ref int i, ColumnInfo.Relation r, List<ColumnInfo> pre)
	{
	}

	private static bool isNew(List<ColumnInfo> prebackups, TrialForamtionProto p)
	{
		return false;
	}

	public static void HollowOutActiveArray()
	{
	}

	private static void updateCandidates(List<ColumnInfo> mine, List<ColumnInfo> source, List<int> found)
	{
	}

	public static void GetOnBoard(int a, int b)
	{
	}

	public static void GetOffBoard(int b)
	{
	}

	public static void ChangeIndexOnBoard(int a, int b)
	{
	}

	private static void setMineStandTheFirstPosition()
	{
	}

	public static Hero[] NewHeroArray(BattleArray array, int c)
	{
		return null;
	}

	private static bool isColumnTheSame(Hero[] a, Hero[] b)
	{
		return false;
	}

	public static bool IsColumnEmpty(Hero[] a)
	{
		return false;
	}

	public static List<int> InSupportersIndex()
	{
		return null;
	}

	public static void UpdateStrangers(List<TrialForamtionProto> strangers)
	{
	}

	public static void ClearExternalColumns()
	{
	}

	public static TrialInfoProto.SuperStageProto GetSuperStage(int index)
	{
		return null;
	}

	public static void SetSuperStageRewardable(int index)
	{
	}

	public static int GetGoldenBoxCount()
	{
		return 0;
	}

	public static int GetSilverBoxCount()
	{
		return 0;
	}

	public static int GetAddedTrialCoins(S2CTrialStageRewardAck ack)
	{
		return 0;
	}
}
