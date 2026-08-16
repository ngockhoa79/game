using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class SkillCtrller : MonoBehaviour
{
	public int SkillId;

	public int SourceFighterId;

	public int MainTargetId;

	public List<int> TargetFighters;

	private int ChildrenFsmFinishCount;

	private GameObject sourceFsmObject;

	private GameObject targetFsmObject;

	private PlayMakerFSM sourceFsm;

	private Dictionary<int, PlayMakerFSM> targetFsms;

	private List<BuffAddProto> addBuffList;

	private List<HarmInfoProto> harmList;

	private List<PropertyChangeProto> propertyChangeList;

	private List<BuffActionEffectProto> otherEffectBuffList;

	private bool leftWin;

	private int batterCount;

	private int targetReadyCounter;

	private int hitTimes;

	private Dictionary<int, int> currentHitDic;

	private Dictionary<int, int> harmAddupDic;

	public void InitSkill(int _skillId, int _sourceId, List<int> _targetIdList)
	{
		SkillId = _skillId;
		SourceFighterId = _sourceId;
		TargetFighters = _targetIdList;
		if (_targetIdList != null && _targetIdList.Count > 0)
		{
			MainTargetId = _targetIdList[0];
		}
	}

	public void InitSkill(SkillEffectProto _action)
	{
		if (_action == null) return;
		SkillId = _action.SkillId;
		SourceFighterId = _action.SourceFighterId;
		TargetFighters = new List<int>();
		if (_action.Harms != null)
		{
			foreach (var harm in _action.Harms)
			{
				TargetFighters.Add(harm.TargetFighterId);
			}
		}
		if (TargetFighters.Count > 0)
		{
			MainTargetId = TargetFighters[0];
		}
	}

	public void SetHarmList(List<HarmInfoProto> _list)
	{
		harmList = _list;
	}

	public void SetHarmList(HarmInfoProto _harmInfo)
	{
		if (harmList == null) harmList = new List<HarmInfoProto>();
		harmList.Add(_harmInfo);
	}

	public void SetBuffAddList(List<BuffAddProto> _list)
	{
		addBuffList = _list;
	}

	public void SetBuffAddList(BuffAddProto _addProto)
	{
		if (addBuffList == null) addBuffList = new List<BuffAddProto>();
		addBuffList.Add(_addProto);
	}

	public void SetBatterCount(int _batter)
	{
		batterCount = _batter;
	}

	public void SetPropertyChangeList(List<PropertyChangeProto> _list)
	{
		propertyChangeList = _list;
	}

	public void SetOtherEffectBuffList(List<BuffActionEffectProto> _list)
	{
		otherEffectBuffList = _list;
	}

	public void SetDuelWinSide(bool _left)
	{
		leftWin = _left;
	}

	private void SetFighters(int MainTargetId)
	{
		this.MainTargetId = MainTargetId;
	}

	private void SetTarget(int _fighterId, string _objectName)
	{
	}

	private void NotifyAllInitOver()
	{
	}

	private void HandleSpecialSkill()
	{
	}

	private void HandleSkillSounds()
	{
	}

	public void HandleChildMsg(SkillCtrllerChildMsgType _type, GameObject _object)
	{
	}

	public HeroGetHitResultType GetHitResult(int _targetFighterId)
	{
		if (harmList != null)
		{
			for (int i = 0; i < harmList.Count; i++)
			{
				if (harmList[i] != null && harmList[i].TargetFighterId == _targetFighterId)
				{
					if (!harmList[i].IsHit) return HeroGetHitResultType.Dodge;
					if (harmList[i].IsBlock) return HeroGetHitResultType.Block;
					return HeroGetHitResultType.Hurt;
				}
			}
		}
		return HeroGetHitResultType.Hurt;
	}

	private void ShowHitResult(GameObject _target)
	{
		if (harmList != null && BattleManager.Instance != null)
		{
			for (int i = 0; i < harmList.Count; i++)
			{
				HarmInfoProto harm = harmList[i];
				if (harm != null && harm.IsTargetDead)
				{
					BattleManager.Instance.FighterDieMoment(harm.TargetFighterId);
				}
			}
		}
		else if (_target != null && BattleManager.Instance != null)
		{
			BattleManager.Instance.FighterDieMoment(MainTargetId);
		}
	}

	private void ChangeProperty(GameObject _target)
	{
	}

	private void CheckCombo(GameObject _hero)
	{
	}

	private void HandleTargetReady(GameObject _hero)
	{
	}

	private void StartDuel(GameObject _hero)
	{
	}

	private void DuelOver(int _fighterId, bool _die)
	{
	}

	private void HideHeroAttachment(GameObject _hero)
	{
	}

	private void FighterDie(GameObject _hero)
	{
	}

	private void ShowNamePad(GameObject _hero)
	{
	}

	private void FighterSpeak(GameObject _hero)
	{
	}

	private void SpeakSideWin(GameObject _hero)
	{
	}

	private void SetSkillNameInUI(GameObject _nameObject)
	{
	}

	private void ShowSkillDescription(GameObject _object)
	{
	}

	private void HandleCutinStart()
	{
	}

	private void HandleCutinOver()
	{
	}

	private void HandleHitEvents(GameObject _hero)
	{
	}

	private void CheckFighterDie()
	{
	}

	private void ChildFsmFinish(string _name)
	{
	}

	public void DestroySkill()
	{
	}

	public void ClearAll()
	{
	}

	private void OnDestroy()
	{
	}

	public void HandleAddBuff(GameObject _target)
	{
	}

	private BuffAddProto FindBuffByFighterId(int _fighterId)
	{
		return null;
	}

	public float GetWaveHitTime(GameObject _hero)
	{
		return 0f;
	}
}
