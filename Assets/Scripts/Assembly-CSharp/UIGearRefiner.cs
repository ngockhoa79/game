using System;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGearRefiner : IceUIBase
{
	[SerializeField]
	private UIGearDisplayer GearDisplayer;

	[SerializeField]
	private UIEventListener SelectGearButton;

	[SerializeField]
	private UIEventListener AddCrystalButton;

	[SerializeField]
	private UIEventListener AddStoneButton;

	[SerializeField]
	private UIEventListener AddCoinButton;

	[SerializeField]
	private GameObject EmptySlot;

	[SerializeField]
	private GameObject GearSlot;

	[SerializeField]
	private UILabel lblStoneNimber;

	[SerializeField]
	private UILabel lblGoldNumber;

	[SerializeField]
	private UILabel lblCrystalNumber;

	[SerializeField]
	private UILabel lblGearName;

	[SerializeField]
	private UISprite OrgMajorBufIcon;

	[SerializeField]
	private UISprite OrgMajorBufTxt;

	[SerializeField]
	private UISprite RefineMajorBufIcon;

	[SerializeField]
	private UISprite RefineMajorBufTxt;

	[SerializeField]
	private UILabel OrgMajorBufNumber;

	[SerializeField]
	private UILabel RefineMajorBufNumber;

	[SerializeField]
	private UILabel OrgMinorBuf1Number;

	[SerializeField]
	private UILabel OrgMinorBuf1Empty;

	[SerializeField]
	private UILabel RefineMinorBuf1Number;

	[SerializeField]
	private IceUIToggleButton OrgMinorBuf1Lock;

	[SerializeField]
	private IceUIToggleButton OrgMinorBuf2Lock;

	[SerializeField]
	private UILabel OrgMinorBuf2Number;

	[SerializeField]
	private UILabel OrgMinorBuf2Empty;

	[SerializeField]
	private UILabel RefineMinorBuf2Number;

	[SerializeField]
	private UISprite OrgMinorBuf1Txt;

	[SerializeField]
	private UISprite RefineMinorBuf1Txt;

	[SerializeField]
	private UISprite OrgMinorBuf2Txt;

	[SerializeField]
	private UISprite RefineMinorBuf2Txt;

	[SerializeField]
	private UISprite OrgMinorBuf1Question;

	[SerializeField]
	private UISprite OrgMinorBuf2Question;

	[SerializeField]
	private UILabel lblConsumeGold;

	[SerializeField]
	private UILabel lblConsumeStones;

	[SerializeField]
	private UILabel lblRefineLevel;

	[SerializeField]
	private UIEventListener RefineButton;

	[SerializeField]
	private UIEventListener DownLevelButton;

	public Action OnSelectGear;

	private EquipmentItemProto.LockCodeEnum lockType;

	private int requireRefineGold;

	private int requireRefineStoneCount;

	private int[] lockStatus;

	private int NormalRefineStoneCount;

	public int PreMajorValue;

	public EquipmentItemProto.AppendProperty PreProperty1;

	public EquipmentItemProto.AppendProperty PreProperty2;

	private GameObject StoneExchangePopupObj;

	private GameObject GearDownLevelPopupObj;

	private UIGearStoneExchange StoneExchangePopup;

	private UIGearDownLevel GearDownLevelPopup;

	private bool isInRefine;

	private const string COLOR_YELLOW = "[FFE500]";

	private const string COLOR_RED = "[FF0000]";

	private GearHolding holding;

	public GearHolding Holding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public GearHolding ResetHolding
	{
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void clear()
	{
	}

	private void set(GearHolding holding)
	{
	}

	private bool DisplayConsumeStonesBar()
	{
		return false;
	}

	private void Refresh()
	{
	}

	private void OnDownLevelClicked(GameObject obj)
	{
	}

	private void OnGearDownLevelEntered()
	{
	}

	private void OnGearDownLevelClosed()
	{
	}

	private void OnClearLevelClicked(GameObject obj)
	{
	}

	private void OnSelectGearClicked(GameObject obj)
	{
	}

	private void OnStoneExchangeClicked(GameObject obj)
	{
	}

	private void OnStoneExchangeEntered()
	{
	}

	private void OnStoneExchangeClosed()
	{
	}

	private void OnRefineClicked(GameObject obj)
	{
	}

	private void OnUseConsumeStoneClicked(GameObject obj)
	{
	}

	private void UpdateStoneInfo()
	{
	}

	private void OnSelectMinorBufLockClicked(GameObject obj)
	{
	}
}
