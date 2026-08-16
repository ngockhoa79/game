using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearRefineDataMainPropController : MonoBehaviour
{
	public enum GearRefineMainPropState
	{
		GRMP_Null = 0,
		GRMP_Upgrade = 1,
		GRMP_Confirm = 2,
		GRMP_DownGrade = 3,
		GRMP_Restore = 4,
		GRMP_Max = 5,
		GRMP_Invalid = 6
	}

	public UISprite MainPropIcon;

	public UISprite MainPropText;

	public UISprite MainPropArrow;

	public UILabel MainPropOldValue;

	public UILabel MainPropNewValue;

	private GearHolding gear;

	private GearRefineMainPropState currentState;

	public void Prepare()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(GearHolding _gear, GearRefineDataController.GearRefineUIType uiType)
	{
	}

	public void SetState(GearRefineMainPropState newState)
	{
	}

	private void SetPropIcon()
	{
	}
}
