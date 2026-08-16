using System;
using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIBattle : MonoBehaviour
{
	public GameObject AttachmentsRoot;

	public GameObject AttachmentsStory;

	public GameObject Top;

	public GameObject Foot;

	public UISprite SpeedLabel;

	public UIBtRoundOpenCtrller RoundOpenCtrller;

	public UILabel PrizeLbl;

	public UISprite PrizeIcon;

	private readonly Vector3 topInitPos;

	private readonly Vector3 footInitPos;

	private bool prepared;

	public UILabel RoundCounterLabel;

	public UISprite RoundCounterBg;

	public UIBtTopTurnCtrller TurnCounterCtrller;

	public const int MAX_ROUND = 99;

	private int round;

	public const int MAX_TURNS = 15;

	private int turn;

	private int prizeNum;

	public UIBtPlayerNameCtrller NameCtrller;

	public UIBtWordsPlayer WordsPlayer;

	public UIBtTopBar TopLeft;

	public UIBtTopBar TopRight;

	public Dictionary<int, GameObject> IDFighterMapping;

	public Dictionary<int, UIBtFighterAttachments> IDAttachmentsMapping;

	public GameObject LootRoot;

	private Dictionary<int, List<GameObject>> lootsDic;

	public BattleWinLoseCtrller WinLoseCtrller;

	public GameObject KOSplashMask;

	private bool skipped;

	public BattleResultCtrller ResultCtrller;

	public GameObject LoadAnim;

	public UILabel SkillDescLabel;

	public GameObject CardIntoBattleRoot;

	private Dictionary<int, GameObject> IDCardInMapping;

	public UIBtBossModuleCtrller bossModuleCtrller;

	public BattleStoryCtrller storyCtrller;

	public UILabel reportIdLabel;

	private const int WIDGETS_OUT_TOP = 110;

	private const int WIDGETS_OUT_FOOT = 60;

	private bool TopShow;

	public int Round
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Turn
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int PrizeNum
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void prepareWidgets()
	{
		if (prepared) return;
		prepared = true;
		if (RoundCounterLabel != null) RoundCounterLabel.text = "1";
		if (NameCtrller != null) NameCtrller.SetName("Player", "Enemy");
	}

	public void ShowRoundOpen(int _round, Action _callBack)
	{
		round = _round;
		if (RoundCounterLabel != null) RoundCounterLabel.text = _round.ToString();
		_callBack?.Invoke();
	}

	public void AddPrize()
	{
		prizeNum++;
		if (PrizeLbl != null) PrizeLbl.text = prizeNum.ToString();
	}

	public void ShowPrizeGroup(bool _show)
	{
		if (PrizeLbl != null) PrizeLbl.gameObject.SetActive(_show);
	}

	public void ShowSpeedGroup(bool _show)
	{
		if (SpeedLabel != null) SpeedLabel.gameObject.SetActive(_show);
	}

	public void SetName(string _left, string _right)
	{
		if (NameCtrller != null)
		{
			NameCtrller.SetName(_left, _right);
		}
	}

	public UIBtFighterAttachments GetAttachments(int ID)
	{
		return null;
	}

	public UIBtFighterAttachments AddAttachments(int fighterID, GameObject fighter, bool isAtLeftSide, bool isSupport)
	{
		return null;
	}

	public UIBtFighterAttachments CreateStoryAttachment(GameObject _hero, bool _left)
	{
		return null;
	}

	public void CheckTopHeads()
	{
	}

	public void AddBuff(int _fighterId, int _buffId, bool _left)
	{
	}

	public void RemoveBuff(int _fighterId, int _buffId, bool _left)
	{
	}

	public void ClearFighters(bool _left)
	{
	}

	public void FighterDie(int _fighterId)
	{
	}

	public void ClearWords()
	{
	}

	public void PlayHeadInAnim(int _fighterId, float _delay)
	{
	}

	public void ResetHeadInAnim(bool _left)
	{
	}

	public void PlayLeaderIconAnim(int _fighterId)
	{
	}

	public void PlaySupportIconAnim(int _fighterId)
	{
	}

	public void SetSkillNameInAttachment(int _fighterId, int _skillId, GameObject _nameObject)
	{
	}

	public void AddLootToDic(Dictionary<int, List<ThingHolding>> _dic)
	{
	}

	public void ThrowLoots(GameObject _hero)
	{
	}

	public void ShowKO(bool _show, bool _leftWin)
	{
	}

	public void ShowKOSplashMask(bool _show)
	{
	}

	public void SkipToKO()
	{
	}

	public void ShowUIForSkip(bool _show)
	{
	}

	public void ShowBattleResult()
	{
	}

	public void ShowLoad(bool _in)
	{
	}

	public void ShowSkillDescription(string _text)
	{
	}

	public void CreateIntoBattleCard(UIBtCardIntoBattleInfo _info)
	{
	}

	public void ShowCardIntoBattle(int _fighterId)
	{
	}

	public void ShowCardTurnHero(int _fighterId)
	{
	}

	public void DestroyIntoBattleCard(int _fighterId)
	{
	}

	public void PlayBossWarningAnim()
	{
	}

	public void StopBossWarningAnim()
	{
	}

	public void PlayBossSpeakAnim(Texture _bossTexture, Action _callBack)
	{
	}

	public void StopBossSpeakAnim()
	{
	}

	public void PlayStory(int _pveId, Action _finishCallback, StoryTimingType _timing, int _rightColumn = -1)
	{
	}

	public void PlayTeaching(BattleTeachType _type, Action _finishCallback)
	{
	}

	public void SetReportId(string _id)
	{
	}

	public void ShowReportId(bool _show)
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void InitAll()
	{
	}

	public void ClearAll()
	{
	}

	public void ShowUI(bool _show)
	{
	}

	private void ShowTop(bool _show)
	{
	}

	public void WidgetsOut(bool _out)
	{
	}

	public void DestoryAll()
	{
	}
}
