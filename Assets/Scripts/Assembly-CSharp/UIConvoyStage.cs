using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.GameOperations;
using UnityEngine;

public class UIConvoyStage : IceUIBase
{
	private const int SHIP_DISPLAY_RANGE = 8;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	[SerializeField]
	private UIEventListener ReportButton;

	[SerializeField]
	private UIEventListener RuleButton;

	[SerializeField]
	private UIEventListener ConvoyButton;

	[SerializeField]
	private UILabel LblConvoyLv;

	[SerializeField]
	private UILabel LblLootTimes;

	[SerializeField]
	private UILabel LblConvoyTimes;

	[SerializeField]
	private UILabel LblCrystalNumber;

	[SerializeField]
	private UILabel LblCoinNumber;

	[SerializeField]
	private GameObject StartPointObj;

	[SerializeField]
	private GameObject TerminalObj;

	[SerializeField]
	private GameObject TopObj;

	[SerializeField]
	private GameObject BottomObj;

	[SerializeField]
	private UIEventListener BackgroundDragB;

	[SerializeField]
	private Transform BackgroundTransform;

	[SerializeField]
	private UISprite BackgroundSprite;

	[SerializeField]
	private UIEventListener EncourageButton;

	[SerializeField]
	private UIEventListener BoostButton;

	public GameObject EncourageButtonEnable;

	public GameObject EncourageButtonDisable;

	public GameObject BoostButtonEnable;

	public GameObject BoostButtonDisable;

	public IceAnimatorTotalCommander EncourageButtonAnim;

	public IceAnimatorTotalCommander BoostButtonAnim;

	[SerializeField]
	private UILabel textEncouragePrice;

	[SerializeField]
	private UILabel textBoostPrice;

	[SerializeField]
	private GameObject SmallMapStartTop;

	[SerializeField]
	private GameObject SmallMapStartBottom;

	[SerializeField]
	private GameObject SmallMapEnd;

	[SerializeField]
	private GameObject EncourageInfo;

	[SerializeField]
	private GameObject BoostInfo;

	[SerializeField]
	private UILabel textEncourageInfoValue;

	[SerializeField]
	private UILabel textBoostInfoValue;

	[SerializeField]
	private UINotificationAttacher uiNotificationAttacher;

	public UIEventListener ShipListButton;

	public IceMovementAnimator GoldAniMove;

	public IceAnimatorTotalCommander GoldAni;

	public UILabel GoldAniValue;

	public Action OnReturn;

	public Action OnHomePage;

	public Action<EscortLobbyData> OnEnterArrayEditor;

	public Action<Friend> OnViewPlayerInfo;

	public Action<int, int> E_ShowStartSetupUI;

	private List<UIConvoyShip> ShipList;

	private UIConvoyShip myShip;

	private List<UIConvoyShipMapDot> ShipDotList;

	private ConvoyInfoOp op;

	private int MyShipRemainTime;

	private int ExpAdd;

	private Timer shipMotionTimer;

	private Timer shipUpdateTimer;

	private UIConvoyLootWin lootWinPanel;

	private UIConvoyLootLose lootLosePanel;

	private UIConvoyDefenseLose defenseLosePanel;

	private UIConvoyScoreboard scoreboardPanel;

	private UIConvoyFinished convoyFinishedPanel;

	private UIConvoySelfInfo selfInfoPopup;

	private UIConvoyInterceptInfo interceptInfoPopup;

	private UIConvoyShipListPanel shipListPanel;

	private UIConvoyReportPanel reportPopupPanel;

	private UIRulePanel rulePopupPanel;

	private UIConvoyDefenseWin defenseWinPanel;

	private float EscortTotalDistanceUI;

	private float EscortTotalDistanceMap;

	private float EscortTotalDistanceData;

	private static readonly int ShipMotionRate;

	private string textMyShipTimeLeft;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void EnterScene()
	{
	}

	protected override void DoDispose()
	{
	}

	public void OnApplicationPause(bool pauseStatus)
	{
	}

	private void FetchShipsData()
	{
	}

	private void RequestAndOpenStage()
	{
	}

	private void SetData()
	{
	}

	private void CheckPopups()
	{
	}

	private void OnShipUpdateTimer(Timer self)
	{
	}

	private void OnShipMotionTimer(Timer self)
	{
	}

	private bool RemoveShip(UIConvoyShip shipToRemove)
	{
		return false;
	}

	private void OnConvoyFinished(int remainingGold)
	{
	}

	private void PickupReward(int remainingGold)
	{
	}

	public void OnPopupPanelClose()
	{
	}

	private ShipLayerInfo SpawnPlayerShip(EscortLobbyData player)
	{
		return null;
	}

	private void SpawnPlayerShips()
	{
	}

	private void ClearPlayerShips()
	{
	}

	private void SetEncourageInfo()
	{
	}

	private void SetBoostInfo()
	{
	}

	private void OnViewShip(EscortLobbyData shipData)
	{
	}

	private void OnDragShip(Vector2 offset)
	{
	}

	private void OnShipMoneyChange(Vector3 screenPos, int addMoney)
	{
	}

	private void OnViewPlayerDetail(Friend f)
	{
	}

	private void OnIntercept(EscortLobbyData data)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnConvoyClicked(GameObject obj)
	{
	}

	public void OnStartShipSuccess(EscortTargetProto targetProto)
	{
	}

	public void OnShipListShipSelected(EscortLobbyData shipData)
	{
	}

	private void OnShipListButtonClicked(GameObject obj)
	{
	}

	private void OnReportClicked(GameObject obj)
	{
	}

	private void OnRuleClicked(GameObject obj)
	{
	}

	private void RequestEncourage()
	{
	}

	private void RequestBoost()
	{
	}

	private void OnEncourageClicked(GameObject obj)
	{
	}

	private void OnBoostClicked(GameObject obj)
	{
	}

	private void Update()
	{
	}

	private void OnEscortBeWrestMessage(object msg, int msgId)
	{
	}

	private void OnEscortCompleteMessage(object msg, int msgId)
	{
	}

	private void NotifyServerClearBeWrestInfo()
	{
	}

	private void NotifyServerClearScoreboardInfo()
	{
	}

	private void EnableConvoy(bool bEnable)
	{
	}

	private void EnableBoost(bool bEnable)
	{
	}

	private void EnableEncourage(bool bEnable)
	{
	}

	private UIConvoyShip SearchShip(int shipID)
	{
		return null;
	}

	private UIConvoyShipMapDot SearchShipDot(int shipID)
	{
		return null;
	}

	private void OnShipInfoChangeBoosted(EscortTargetProto shipProto)
	{
	}

	private void OnShipInfoChangeEncouraged(EscortTargetProto shipProto)
	{
	}

	private void OnShipInfoChangeLooted(EscortTargetProto shipProto)
	{
	}

	private void OnShipInfoChangeNewShip(EscortTargetProto shipProto)
	{
	}

	private void OnShipInfoChangeMessage(object msg, int msgId)
	{
	}

	private void OnShipDefenseSuccessMessage(object msg, int msgId)
	{
	}

	private void UpdateShipRemainTimeText()
	{
	}

	private void SetPanelNull(UIConvoyPopupBase.PopupID panelID)
	{
	}

	private void CloseAllPopupPanels()
	{
	}
}
