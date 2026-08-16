using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearRefineDataSubPropController : MonoBehaviour
{
	public enum GearRefineSubPropColumeState
	{
		GRSPC_Null = 0,
		GRSPC_Property = 1,
		GRSPC_PropertyCopyFromLeft = 2,
		GRSPC_None = 3,
		GRSPC_Unknown = 4,
		GRSPC_Invalid = 5
	}

	public enum GearRefineSubPropLockState
	{
		GRSPL_Null = 0,
		GRSPL_FixedUnlock = 1,
		GRSPL_FixedLock = 2,
		GRSPL_Locked = 3,
		GRSPL_Unlocked = 4,
		GRSPL_Invalid = 5
	}

	public GameObject LockFixedUnlockGroup;

	public GameObject LockFixedLockGroup;

	public GameObject LockButtonGroup;

	public UISprite LockIcon;

	public UIEventListener LockButton;

	public GameObject PreviousValueGroup;

	public GameObject PreviousNoneGroup;

	public GameObject PreviousUnknownGroup;

	public UISprite PreviousPropText;

	public UILabel PreviousPropValue;

	public GameObject SubPropArrow;

	public GameObject NextValueGroup;

	public GameObject NextNoneGroup;

	public GameObject NextUnknownGroup;

	public UISprite NextPropText;

	public UILabel NextPropValue;

	public Action onLockStateChanged;

	public IceAnimatorTotalCommander LockAnimation;

	public IceAnimatorTotalCommander UnlockAnimation;

	private GearHolding gear;

	private int subPropSlot;

	private GearRefineDataController.GearRefineUIType uiType;

	private GearRefineSubPropColumeState previousColumeState;

	private GearRefineSubPropColumeState nextColumeState;

	public GearRefineSubPropLockState lockState { get; private set; }

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(GearHolding _gear, int slotID, GearRefineDataController.GearRefineUIType uiType)
	{
	}

	protected void SetLockState(GearRefineSubPropLockState newLockState)
	{
	}

	protected void SetPreviousColumeState(GearRefineSubPropColumeState newColState)
	{
	}

	protected void SetNextColumeState(GearRefineSubPropColumeState newColState)
	{
	}

	protected bool GetPreviousOperationLockState()
	{
		return false;
	}

	public void OnLockButtonClicked(GameObject gameObject)
	{
	}
}
