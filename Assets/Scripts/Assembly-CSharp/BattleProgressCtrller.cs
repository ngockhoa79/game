using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class BattleProgressCtrller : MonoBehaviour
{
	private enum BattleState
	{
		WaitLoader = 0,
		WaitRemainAddHp = 1,
		LoadRoundRes = 2,
		LoadHeros = 3,
		InitData = 4,
		BeforeStory = 5,
		EnterBattle = 6,
		BossWarning = 7,
		WaitNewTeaching = 8,
		Fight = 9,
		KO = 10,
		WinSideSpeak = 11,
		AfterStory = 12,
		Settlement = 13,
		Wait = 14,
		None = 15
	}

	[CompilerGenerated]
	private sealed class _003Ctest_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003Ctest_003Ed__51(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GameObject HerosNode;

	public GameObject SkillsNode;

	public GameObject BuffsNode;

	public GameObject SkillUnblockNode;

	public GameObject EffectsNode;

	public BattleLoader battleLoader;

	public UIBattle uiCtrller;

	public GameObject TopEffectCamera;

	public BattleCameraCtrller battleCameraCtrller;

	private UIBtButtons FootBtnsCtrller;

	private BattleReport report;

	private BattleManager battleManager;

	private BattleReportM reportManager;

	private PipelineManager pipelineManager;

	private int currentRound;

	private int currentAction;

	private float waitResultTimer;

	private float wanderTimer;

	private float koTimer;

	private bool destoryed;

	private bool passiveSkillCastOver;

	private bool battleOver;

	private bool koStartShow;

	private bool fightStarted;

	private bool loadRoundStart;

	private bool uiTeamRemoved;

	private bool replay;

	private bool skipNotVideo;

	private bool newTeached;

	private bool passedDuplication;

	private HashSet<int> columnStoryPlayed;

	private const float WARNING_TIME = 1.7f;

	private bool isBossLevel;

	private bool bossWarning;

	private float bossTimer;

	private bool printReport;

	private const float OPEN_FLAME_TIME = 1.5f;

	private BattleState currentState;

	private BattleState lastState;

	private int currentLoadingRound;

	private List<BattleResourceItem> roundResList;

	private float loadInTimer;

	private List<ReportHeroInfo> battleFighterList;

	private List<ReportHeroInfo> supportFighterList;

	private List<int> storyLeftHeroList;

	private List<int> storyRightHeroList;

	private int storyFighterId;

	private float storyStartTimer;

	private bool beforePlayed;

	private bool teachSkillCastOver;

	private bool teachUiShown;

	private int teachSkillId;

	private float waitRemainTimer;

	private bool winSpeakOver;

	private bool afterPlayed;

	private bool settlementShowOver;

	private bool skipped;

	private bool passiveGaping;

	private float passiveGapTimer;

	private bool NeedBossBgm => false;

	private bool NeedBeforeStory => false;

	private bool GAME_FIRST_ROUND => false;

	private bool IsEnteringBattle => false;

	private void Update()
	{
	}

	private void SetCurrentState(BattleState _state)
	{
	}

	private void Awake()
	{
	}

	private void InitManager()
	{
	}

	private void BeforeLoadInit()
	{
	}

	private void BattleLoaderResult(bool _success)
	{
	}

	private void HandleLoadRoundRes()
	{
	}

	private void LoadRoundResources()
	{
	}

	[IteratorStateMachine(typeof(_003Ctest_003Ed__51))]
	private IEnumerator test()
	{
		return null;
	}

	private void LoadRoundResourcesFinishCallback()
	{
	}

	private void HandleLoadHeros()
	{
	}

	private void AfterLoadInit()
	{
	}

	private void HandleBeforeStory()
	{
	}

	private void OnBeforeStoryOver()
	{
	}

	private bool HasStory(StoryTimingType _timing)
	{
		return false;
	}

	private bool HasInBattleStory(int _rightColumn)
	{
		return false;
	}

	private void LoadOut()
	{
	}

	private void ShowScreenSwitchEffect()
	{
	}

	private void HandleEnterbattle()
	{
	}

	private void OnInBattleStoryOver()
	{
	}

	private void HandleBossWarning()
	{
	}

	private void HandleWaitNewTeaching()
	{
	}

	private void onTeachOver()
	{
	}

	private void SetVsName(EnterBattleProto _proto)
	{
	}

	private void HandleFightEvent()
	{
	}

	private bool IsTeachingLeaderSkill(BattleActionProto _action)
	{
		return false;
	}

	private void ShowSupportTeaching(int _skillId)
	{
	}

	private void ShowRourndStartAnim()
	{
	}

	public void RoundStartAnimOver()
	{
	}

	private void RoundOver(RoundOverProto _overProto)
	{
	}

	private void HandleWaitRemainAddHp()
	{
	}

	private void HandleBattleKO()
	{
	}

	private void HandleWinSideSpeak()
	{
	}

	private void HandleAfterStory()
	{
	}

	private void OnAfterStoryOver()
	{
	}

	private void HandleSettlements()
	{
	}

	private void HandleWaitEvent()
	{
	}

	public void ReplayBattle()
	{
	}

	public bool SkipBattleHandled()
	{
		return false;
	}

	public void DestoryAll()
	{
	}

	private void ClearAll()
	{
	}

	private bool PassvieSkillCastOver()
	{
		return false;
	}

	private void CheckHerosWander()
	{
	}

	private void CheckTeamOver(bool _leftWin)
	{
	}

	private void OnActionComplete(ActionCompleteMsgType _msg)
	{
	}

	private void GotoKO()
	{
	}
}
