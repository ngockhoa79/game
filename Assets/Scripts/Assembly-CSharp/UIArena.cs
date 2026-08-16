using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.GameOperations;
using UnityEngine;

public class UIArena : IceUIBase
{
	public static Action OnNotRevokeCurrentIntent;

	private const string BattleReportPrefab = "ArenaBattleReporter";

	private const string RulesPrefab = "ArenaRulesDisplayer";

	private const string RankListPrefab = "ArenaRankList";

	private const string ResCategory = "uiarena";

	private Rect LayoutRect;

	private static UIArena mUIArena;

	public static bool GuidanceActivate;

	public Action<Player, bool, int, int> OnChallengerClicked;

	public Action OnHomePage;

	public Action OnReturn;

	public Action OnRedPack;

	public Action OnRefresh;

	public UIEventListener.VoidDelegate OnPopRank;

	private List<PVPPlayer> fullPlayerList;

	private Dictionary<int, GameObject> loadedPlayerDisplayers;

	public MeDisplayer MeDisp;

	public UIArChallengers Challengers;

	public UIEventListener HomePageButton;

	public UIEventListener ExchangeButton;

	public UIEventListener BattleRptButton;

	public UIEventListener RulesButton;

	public UIEventListener ReturnButton;

	public UIEventListener RankListButton;

	public UIEventListener RedpackBtn;

	public UIEventListener RefreshBtn;

	public UIButton RefreshUIButton;

	public UIArChallengeCounter Counter;

	public Transform WallPaper;

	public UIPanel ScrollerPanel;

	public UIDragObject Scroller;

	public static int SNATCH_RED_PACKAGE_RANK;

	private int ownRank;

	private bool isTopDeadSpot;

	private bool isBottomDeadSpot;

	private bool isLoading;

	private GameObject startGo;

	private GameObject endGo;

	private UIArBattleReporter battleReporter;

	private UIArRulesDisplayer rulesDisplayer;

	private UIArRankList rankList;

	private int challengedTimes;

	public int BoughtTimes;

	public IceAnimatorTotalCommander CraneUp;

	public IceAnimatorTotalCommander CraneDown;

	private UIHeroLoader uiHeroLoader;

	public static bool IsDraggable;

	public IceAnimatorTotalCommander UpArrow;

	public IceAnimatorTotalCommander DownArrow;

	private int minRank;

	private int maxRank;

	private Transform displayers;

	public static UIArena Arena => null;

	public event Action OnMeClicked
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<int, int> OnRequestChallengers
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void requestAndOpenPVP()
	{
	}

	private void handleReqFail(object res, NetManager.CoreErrorCode err_code)
	{
	}

	public void PushData(RequestChallengersOp.PVPOperationData d)
	{
	}

	public void ResetTodaysChallengeFilter(int v)
	{
	}

	public void SetFullPVPData(RequestChallengersOp.PVPOperationData opData)
	{
	}

	private void fullArena(List<PVPPlayer> full)
	{
	}

	private void scrollerDragged(Vector2 delta)
	{
	}

	private void updateArrows()
	{
	}

	private void activeArrows(int frames, bool up, bool down)
	{
	}

	private void activeArrow(bool active, IceAnimatorTotalCommander cmd)
	{
	}

	private void adjustCraneAnimations(float y)
	{
	}

	private void redirect(PlayerDisplayer disp)
	{
	}

	private void bindRedirect(UIEventListener l)
	{
	}

	private PlayerDisplayer addChallenger(PVPPlayer challenger)
	{
		return null;
	}

	private void handlePlayerDisplayerClicked(PlayerDisplayer disp, Player p)
	{
	}

	private bool isInChallengeRange(int currentRankingValue, int targetRnakingValue)
	{
		return false;
	}

	private int pickUpNearestScrollIndex()
	{
		return 0;
	}

	private void scrollTo(int challengerIndex)
	{
	}

	public void ActivateFunnyRenderers(bool activate)
	{
	}

	private void showExchangeContent(GameObject btn)
	{
	}

	private void showBattleReportContent(GameObject btn)
	{
	}

	private void showRankListContent(GameObject btn)
	{
	}

	private void showRulesContent(GameObject btn)
	{
	}

	private void clean()
	{
	}

	private void cleanSubUI(IceUIBase sub)
	{
	}

	protected override void DoDispose()
	{
	}
}
