using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class BattleReportM : MonoBehaviour
{
	private enum AttackType
	{
		NormalAttack1 = 0,
		NormalAttack2 = 1,
		HeavyAttack = 2,
		SkillAttack = 3
	}

	private int TestPVEID;

	private BattleReportType defaultReportType;

	public string BattleReportFilePath;

	private Friend passer;

	private BattleReportProto battleReportProto;

	public Dictionary<int, string> NameDic;

	public bool isChallanged;

	public bool isPassed;

	public int FriendPractiesPoint;

	private DuplicateSettlement pduplicateSettlement;

	private PVPSettlement ppvpSettlement;

	private SkillRobSettlement pskillRobSettlement;

	public bool isBossLevel;

	[HideInInspector]
	public bool ReportLoaded;

	private Dictionary<string, BattleResourceItem> reportResDic;

	private Dictionary<string, BattleResourceItem>[] reportRoundResArray;

	private List<HashSet<ReportHeroInfo>> roundFighterList;

	private List<HashSet<ReportHeroInfo>> roundSupportFighterList;

	private HashSet<int> storyLeftSpineSet;

	private HashSet<int> storyRightSpineSet;

	private HashSet<int> storyTextureIdSet;

	private int currentRound;

	public BattleReportType DefaultReportType => default(BattleReportType);

	public Friend PasserInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	[HideInInspector]
	public BattleReport battleReport { get; private set; }

	public DuplicateSettlement duplicateSettlement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PVPSettlement pvpSettlement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SkillRobSettlement skillRobSettlement
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BattleReportType reportType { get; private set; }

	public bool IsPVEReport => false;

	public bool IsVideoReport => false;

	public bool IsVipCanSkipReport => false;

	public bool MySideIsRight => false;

	private bool NeedCheckMySide => false;

	public bool HasLootChest => false;

	public int BattleId { get; private set; }

	public string battleBg { get; private set; }

	public bool CanShowStory => false;

	private void Awake()
	{
	}

	public void ImportBattleReport(BattleReport report)
	{
	}

	public void InitBattleReport(BattleReport _report, BattleReportType _type, int _Id = -1)
	{
	}

	public void LoadBattleReport()
	{
	}

	private void ExportBattleReport()
	{
	}

	public void UnloadBattleReport()
	{
	}

	public void DestoryAll()
	{
	}

	private void DestorySettlements()
	{
	}

	public List<int> GetBossFighterIds()
	{
		return null;
	}

	private int GetRightFormationFighterId(int _configPos)
	{
		return 0;
	}

	private void PrintReport()
	{
	}

	private void GenReportResources()
	{
	}

	private void HandleOneActionRes(BattleActionProto _action)
	{
	}

	private void AddBuffLastRes(int _buffId)
	{
	}

	private void RemoveUnusedRes(BattleActionProto _action)
	{
	}

	private void AddOneResourceToDic(string _resName, string _resType)
	{
	}

	private void AddSomeResourcesToDic(string _resName, string _resType, int _count)
	{
	}

	private void RemoveAttackRes(HeroGetHitResultType _hitType, AttackType _attackType, int _sourceFighterId)
	{
	}

	private void RemoveGivenHitTypeRes(HeroGetHitResultType _hitType)
	{
	}

	private void RemoveOneResFromDic(string _resName)
	{
	}

	private void AddHeroRelatedRes(int _heroId, bool _hasBoneEffect)
	{
	}

	private void AddHeroBoneEffect(int _heroId)
	{
	}

	private void AddHeroVoice(int _heroId)
	{
	}

	private void HandlePrefabRelatedRes(string _prefabName)
	{
	}

	public List<BattleResourceItem> GetLoadResourceContents()
	{
		return null;
	}

	public List<BattleResourceItem> GetLoadResourceByRound(int _round)
	{
		return null;
	}

	public List<ReportHeroInfo> GetFightersListByRound(int _round)
	{
		return null;
	}

	public List<ReportHeroInfo> GetSupportFightersListByRound(int _round)
	{
		return null;
	}

	public List<int> GetStoryHeroList(bool _left)
	{
		return null;
	}

	public List<BattleResourceItem> GetEffectResources()
	{
		return null;
	}

	public HashSet<int> GetStoryTextureIdSet()
	{
		return null;
	}
}
