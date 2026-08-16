using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearRefineDowngradeController : IceUIBase
{
	public UISprite TitleText;

	public GameObject DataAnchorPoint;

	public UILabel StoneValue;

	public UIEventListener ButtonCancel;

	public UIEventListener ButtonConfirm;

	private GearHolding gear;

	private GearRefineDataController dataController;

	private double returnStoneRate;

	private GearRefineDataController.GearRefineUIType uiType;

	public Action<GearHolding> onDowngradeSuccess;

	public Action<GearHolding> onRestoreSuccess;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void onClose(GameObject btn)
	{
	}

	public void SetData(GearHolding _gearHolding, GearRefineDataController.GearRefineUIType uiType)
	{
	}

	public void OnCancelButtonClicked(GameObject gameObject)
	{
	}

	public void OnConfirmButtonClicked(GameObject gameObject)
	{
	}

	public void RequestDowngrade()
	{
	}

	public void RequestRestore()
	{
	}
}
