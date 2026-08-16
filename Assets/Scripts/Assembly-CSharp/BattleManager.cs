using System;
using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
	public delegate void ActionCompleteEvent(ActionCompleteMsgType _msg);

	private Dictionary<int, BattleHeroInfo> battleHeroDic;

	private Dictionary<int, BattleHeroInfo> supportHeroDic;

	private Dictionary<int, BattleHeroInfo> storyHerosDic;

	private Dictionary<GameObject, BattleSkillInfo> battleSkillDic;

	private Dictionary<int, BattleBuffInfo> battleBuffDic;

	private HashSet<int> lockFighterSet;

	private HashSet<int> waitDieList;

	private HashSet<int> deadAlreadySet;

	private HashSet<int> loseSideDieSet;

	private BattleLineManager lineManager;

	private BattleReport battleReport;

	public UIBattle uiCtrller;

	private GameObject HerosNode;

	private GameObject SkillsNode;

	private GameObject BuffsNode;

	private GameObject SkillUnblockNode;

	public GameObject EffectsNode;

	private const int LocalSkillUniqueIdStart = 10000;

	private int LocalSkillUniqueId;

	private BattleCameraCtrller battleCameraCtrller;

	private Dictionary<int, Texture> storyTextureDic;

	private bool BlockActions;

	private int catchSkillId;

	private Action<int> OnCatchSkillFinish;

	private static BattleManager _instance;

	public ActionCompleteEvent onActionComplete;

	private GameObject CutinBgEffect;

	private int cutinCounter;

	private Action onStoryOver;

	public static BattleManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = UnityEngine.Object.FindObjectOfType<BattleManager>();
			}
			return _instance;
		}
	}

	public Dictionary<int, BattleHeroInfo> GetBattleHeroDic => battleHeroDic;

	public static void DestoryInstance()
	{
		_instance = null;
	}

	private void Start()
	{
		_instance = this;
		if (battleHeroDic == null) battleHeroDic = new Dictionary<int, BattleHeroInfo>();
		if (supportHeroDic == null) supportHeroDic = new Dictionary<int, BattleHeroInfo>();
		if (storyHerosDic == null) storyHerosDic = new Dictionary<int, BattleHeroInfo>();
		if (battleSkillDic == null) battleSkillDic = new Dictionary<GameObject, BattleSkillInfo>();
		if (battleBuffDic == null) battleBuffDic = new Dictionary<int, BattleBuffInfo>();
		if (lockFighterSet == null) lockFighterSet = new HashSet<int>();
		if (waitDieList == null) waitDieList = new HashSet<int>();
		if (deadAlreadySet == null) deadAlreadySet = new HashSet<int>();
		if (loseSideDieSet == null) loseSideDieSet = new HashSet<int>();
	}

	public void ClearAll()
	{
	}

	public void InitBattleReport(BattleReport _battleReport)
	{
	}

	public void AddToLineManager(BattleHeroInfo _info, bool _forceMiddle)
	{
		if (_info == null) return;
		if (BattleLineManager.Instance != null)
		{
			BattleLineManager.Instance.SetFighterSmallLine(_info, _forceMiddle);
		}
	}

	public void SetRootNodes(GameObject _heroRoot, GameObject _skillRoot, GameObject _buffRoot, GameObject _skillUnblockRoot, GameObject _effectRoot, UIBattle _uiCtrller)
	{
		HerosNode = _heroRoot;
		SkillsNode = _skillRoot;
		BuffsNode = _buffRoot;
		SkillUnblockNode = _skillUnblockRoot;
		EffectsNode = _effectRoot;
		this.uiCtrller = _uiCtrller;
	}

	public void ResetAll()
	{
		ClearAll();
	}

	public bool RegisterBattleHero(int _fighterId, BattleHeroInfo _info)
	{
		if (_info == null) return false;
		if (battleHeroDic == null) battleHeroDic = new Dictionary<int, BattleHeroInfo>();
		battleHeroDic[_fighterId] = _info;
		AddToLineManager(_info, false);
		return true;
	}

	public void UnregisterBattleHero(int _fighterId)
	{
		if (battleHeroDic != null) battleHeroDic.Remove(_fighterId);
		if (BattleLineManager.Instance != null) BattleLineManager.Instance.RemoveFighter(_fighterId);
	}

	public bool RegisterSupportHero(int _fighterId, BattleHeroInfo _info)
	{
		return false;
	}

	public bool RegisterStoryHero(int _fighterId, BattleHeroInfo _info)
	{
		return false;
	}

	public void UnregisterSupportHero(int _fighterId)
	{
	}

	public List<int> GetAllBattleFighters()
	{
		return null;
	}

	public BattleHeroInfo FindBattleHeroInfoByFighterId(int _fighterId)
	{
		return null;
	}

	public GameObject FindBattleHeroObjectByFighterId(int _fighterId)
	{
		return null;
	}

	public void SetHeroVisible(int _fighterId, bool _visible)
	{
	}

	public void HideOtherHeros(int _fighterId)
	{
	}

	public void ShowAllHeros()
	{
	}

	public void FighterDieMoment(int _fighterId)
	{
		if (deadAlreadySet == null) deadAlreadySet = new HashSet<int>();
		deadAlreadySet.Add(_fighterId);
	}

	public void LoadHero(ReportHeroInfo _hero, HeroFightType _type)
	{
	}

	public Texture GetStoryTexture(int _heroId)
	{
		return null;
	}

	public bool HandleNewRoundDeadHero(int _fighterId)
	{
		return deadAlreadySet != null && deadAlreadySet.Contains(_fighterId);
	}

	public bool RegisterBattleSkill(GameObject _skillObject, BattleSkillInfo _skillInfo)
	{
		if (_skillObject == null || _skillInfo == null) return false;
		if (battleSkillDic == null) battleSkillDic = new Dictionary<GameObject, BattleSkillInfo>();
		battleSkillDic[_skillObject] = _skillInfo;
		return true;
	}

	public void UnregisterBattleSkill(GameObject _skillObject)
	{
		if (battleSkillDic != null && _skillObject != null) battleSkillDic.Remove(_skillObject);
	}

	public SkillCtrller CreateSkill(int _skillId)
	{
		GameObject skillGo = new GameObject("Skill_" + _skillId);
		if (SkillsNode != null) skillGo.transform.SetParent(SkillsNode.transform);
		SkillCtrller skill = skillGo.AddComponent<SkillCtrller>();
		skill.SkillId = _skillId;

		BattleSkillInfo skillInfo = new BattleSkillInfo();
		skillInfo.SkillId = _skillId;
		RegisterBattleSkill(skillGo, skillInfo);
		return skill;
	}

	public SkillCtrller CreateUnblockSkill(int _skillId)
	{
		GameObject skillGo = new GameObject("UnblockSkill_" + _skillId);
		if (SkillUnblockNode != null) skillGo.transform.SetParent(SkillUnblockNode.transform);
		SkillCtrller skill = skillGo.AddComponent<SkillCtrller>();
		skill.SkillId = _skillId;

		BattleSkillInfo skillInfo = new BattleSkillInfo();
		skillInfo.SkillId = _skillId;
		RegisterBattleSkill(skillGo, skillInfo);
		return skill;
	}

	public void ShowCutinEffect(int _fighterId, int _skillRarity)
	{
	}

	public void HideCutinEffect()
	{
	}

	public bool HasSkill(int _skillId)
	{
		return false;
	}

	public bool RegisterBattleBuff(int _buffUniqueId, BattleBuffInfo _buffInfo)
	{
		return false;
	}

	public void UnregisterBattleBuff(int _buffUniqueId)
	{
	}

	private void FinishLastBuff(GameObject _buffObject)
	{
	}

	public void CreateBuff(BuffAddProto _buff)
	{
	}

	public void CreateBuff(BuffActionEffectProto _buff)
	{
	}

	public void BuffEffect(BuffActionEffectProto _buff)
	{
	}

	public bool NoBuffAdding()
	{
		return false;
	}

	public bool noHeroLocked()
	{
		return false;
	}

	private bool isLockConflict(HashSet<int> _set)
	{
		return false;
	}

	private void SetLockFighterList(HashSet<int> _set, bool _lock)
	{
	}

	public void CatchSkill(int _skillId, Action<int> _callBack)
	{
	}

	public void UnblockActions()
	{
	}

	public bool CanPresentAciton(BattleActionProto _action)
	{
		return false;
	}

	private bool HandleAction_BuffAdd(BuffAddProto _action)
	{
		return false;
	}

	private bool HandleAction_BuffActionEffect(BuffActionEffectProto _action)
	{
		return false;
	}

	private bool HandleAction_BuffDelete(BuffDeleteProto _action)
	{
		return false;
	}

	private bool HandleAction_EnterBattle(EnterBattleProto _action)
	{
		return false;
	}

	private bool HandleAction_FinalCompetition(FinalCompetitionProto _action)
	{
		return false;
	}

	private bool HandleAction_FinalCompetitionAddSpirit(FinalCompetitionAddSpiritProto _action)
	{
		return false;
	}

	private bool HandleAction_GroupRemainAddHp(GroupRemainAddHpProto _action)
	{
		return false;
	}

	public void BackToOriginLine(int _fighterId)
	{
	}

	private bool HandleAction_NormalAttack(NormalAttackProto _action)
	{
		return false;
	}

	private bool HandleAction_SkillEffect(SkillEffectProto _action)
	{
		return false;
	}

	private bool HandleAction_ToNewLine(ToNewLineProto _action)
	{
		return false;
	}

	private bool HandleAction_TurnOverSign()
	{
		return false;
	}

	public bool HandleLocalSkillSelf(int _skillId, int _fighterId, bool _block)
	{
		return false;
	}

	public bool CastPassiveSkills()
	{
		return false;
	}

	public void AddFighterToDieList(int _fighterId)
	{
	}

	private void HandleDieListFightersDie()
	{
	}

	public void HeroDieImmediately(int _fighterId)
	{
	}

	private void HandleFighterDie(int _fighterId)
	{
	}

	public void HandleRemainGroupWin(bool _left)
	{
	}

	public void HandleRemainGroupIdle()
	{
	}

	public void SpeakSideWin(bool _left)
	{
	}

	public void HandleHerosWander()
	{
	}

	private GameObject GetWanderObject(int _fighterId)
	{
		return null;
	}

	public void ClearHerosWander()
	{
	}

	public void ClearWander(int _fighterId)
	{
	}

	public void ShowSupportActions(int _fighterId)
	{
	}

	public void HandleStory(int _heroId, StoryTemplateExt _story, Action _onFinish)
	{
	}

	public bool HeroIsLeft(int _fighterId)
	{
		return false;
	}

	public void ReplayBattleReport()
	{
	}

	public List<int> GetFightSideHeros(bool _left)
	{
		return null;
	}

	public List<int> GetAliveFightSideHeros(bool _left)
	{
		return null;
	}

	public List<int> GetBattleFightersInLine(int _line)
	{
		return null;
	}

	public Transform GetParentTransform(BattleInstanceType _type)
	{
		return null;
	}

	public float GetHeroWanderXAdd(int _fighterId)
	{
		return 0f;
	}

	public bool NeedFollowMiddleHero(int _fighterId)
	{
		return false;
	}

	public int GetSupportTarget(int _supportId)
	{
		return 0;
	}

	public List<int> GetOppEnemies(int _fighterId)
	{
		return null;
	}

	public List<int> GetBattleEnemies(int _fighterId)
	{
		return null;
	}

	public int GetNearestEnemyFighterId(int _fighterId)
	{
		return 0;
	}

	public float GetNearestOppEnemyPos(int _fighterId)
	{
		return 0f;
	}

	public bool CheckOppDistanceSafe(int _fighterId)
	{
		return false;
	}
}
