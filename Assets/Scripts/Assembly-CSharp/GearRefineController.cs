using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearRefineController : IceUIBase
{
	public enum GearRefineGearState
	{
		GRGS_GearNull = 0,
		GRGS_GearLevelZero = 1,
		GRGS_GearLevelOne = 2,
		GRGS_GearLevelCommon = 3,
		GRGS_GearLevelCommonDowngraded = 4,
		GRGS_GearLevelMax = 5,
		GRGS_GearUnrefinable = 6,
		GRGS_Invalid = 7
	}

	public enum GearRefineUIState
	{
		GRUI_Normal = 0,
		GRUI_Confirm = 1,
		GRUI_Invalid = 2
	}

	public enum RefineUIEnterType
	{
		New = 0,
		Refine = 1,
		Confirm = 2,
		Downgrade = 3,
		Restore = 4
	}

	public GearRefineHeadController HeadController;

	private GearRefineDataController DataController;

	public GameObject DataAnchorPoint;

	public GearRefineConsumablesController ConsumablesController;

	public GearRefineCostController CostController;

	public GameObject ConfirmPanelController;

	public UIEventListener ButtonRefine;

	public UIEventListener ButtonDowngrade;

	public UIEventListener ButtonRestore;

	public UIEventListener ButtonConfirm;

	public UIEventListener ButtonHelp;

	public UISprite ButtonRefineText;

	public UISprite ButtonDowngradeText;

	public UISprite ButtonRestoreText;

	public UISprite DiamondIconDowngrade;

	public UISprite DiamondIconRestore;

	public UILabel ButtonPriceDowngrade;

	public UILabel ButtonPriceRestore;

	public IceAnimatorTotalCommander PropUpgradeAni;

	public GameObject SubPropAAni;

	public GameObject SubPropBAni;

	public UISprite MainPropAniSprite;

	public UILabel MainPropAniLabel;

	public UISprite SubPropAAniSprite;

	public UILabel SubPropAAniLabel;

	public UISprite SubPropBAniSprite;

	public UILabel SubPropBAniLabel;

	public IceAnimatorTotalCommander SlotSetAni;

	public IceAnimatorTotalCommander RefineReadyAni;

	public IceAnimatorTotalCommander RefineSuccessAni;

	public IceAnimatorTotalCommander RestoreAni;

	public IceAnimatorTotalCommander DowngradeAni;

	public IceAnimatorTotalCommander RefineToConfirmAni;

	public IceAnimatorTotalCommander ConfirmToRefineAni;

	private RefineUIEnterType enterSource;

	private GearHolding gear;

	private GearRefineGearState gearState;

	private int stoneCounter;

	private int coinCounter;

	private int diamondCounter;

	private int requiredCoin;

	private int requiredStone;

	private int requiredDiamond;

	private int priceDowngrade;

	private int priceRestore;

	private List<ItemHolding> myStoneItemsSnap;

	private GearRefineUIState CurrentUIState;

	protected override void DoPrepare()
	{
	}

	public void SetData(GearHolding _gearHolding, RefineUIEnterType enterType = RefineUIEnterType.New, GearRefineUIState uiState = GearRefineUIState.GRUI_Normal)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	private void Update()
	{
	}

	private void UpdateCost()
	{
	}

	protected bool CheckCost(int stoneCost, int coinCost, int diamondCost, bool showMessage)
	{
		return false;
	}

	protected bool CheckReady(int stoneCost, int coinCost, int diamondCost)
	{
		return false;
	}

	protected void EnableDowngradeButton(bool bEnable)
	{
	}

	protected void EnableRestoreButton(bool bEnable)
	{
	}

	public void OnGearSubPropLockChanged()
	{
	}

	private void Reset()
	{
	}

	public void OnRefineButtonClicked(GameObject gameObject)
	{
	}

	protected string GetPropSpriteName(EAttrType gearAttribute)
	{
		return null;
	}

	public void OnDowngradeButtonClicked(GameObject gameObject)
	{
	}

	public void OnRestoreButtonClicked(GameObject gameObject)
	{
	}

	public void OnConfirmButtonClicked(GameObject gameObject)
	{
	}

	public void OnDowngradeSuccess(GearHolding newGear)
	{
	}

	public void OnRestoreSuccess(GearHolding newGear)
	{
	}

	public void OnHelpButtonClicked(GameObject buttonClicked)
	{
	}

	public void ChangeUIStateTo(GearRefineUIState new_state)
	{
	}

	public void PlayRefineToConfirm()
	{
	}

	public void PlayConfirmToRefine()
	{
	}

	public bool IsInConfirmUI()
	{
		return false;
	}

	public void OnHeaderControllerClick()
	{
	}
}
