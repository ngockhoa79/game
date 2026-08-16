using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearRefineDataController : MonoBehaviour
{
	public enum GearRefineUIType
	{
		GearRefineUI_Upgrade = 0,
		GearRefineUI_Confirm = 1,
		GearRefineUI_Downgrade = 2,
		GearRefineUI_Restore = 3
	}

	public UILabel GearName;

	public UILabel GearLevel;

	public GameObject GearLevelMaxIcon;

	public GearRefineDataMainPropController MainProperty;

	public GearRefineDataSubPropController SubPropertyA;

	public GearRefineDataSubPropController SubPropertyB;

	public Action onSubPropertyLockChanged;

	private GearHolding gear;

	public bool IsSubPropALocked => false;

	public bool IsSubPropBLocked => false;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(GearHolding _gear, GearRefineUIType uiType)
	{
	}

	public void OnSubPropertyLockChanged()
	{
	}
}
