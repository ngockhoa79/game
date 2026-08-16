using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGearStrengthen : IceUIBase
{
	public static Action OnMirrorStrengthenPopupClosed;

	public GearLvupCtrller gearLevelupUI;

	public GearRefineController gearRefineUI;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	public IceUIBtnGroup strengthenTab;

	public Action OnReturn;

	public Action OnHomePage;

	private int currentTab;

	private int gearLocalId;

	private string CurrentTab;

	public void SetData(GearHolding _gearHolding, int _enterTab)
	{
		currentTab = _enterTab;
		if (_gearHolding != null)
		{
			gearLocalId = _gearHolding.LocalID;
		}
		gameObject.SetActive(true);
		if (gearLevelupUI != null && _gearHolding != null)
		{
			gearLevelupUI.gameObject.SetActive(true);
		}
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoPrepare()
	{
		if (HomePageButton != null)
		{
			HomePageButton.onClick = (go) => { if (OnHomePage != null) OnHomePage(); };
		}
		if (ReturnButton != null)
		{
			ReturnButton.onClick = (go) => { if (OnReturn != null) OnReturn(); };
		}
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
		if (onEnterScreen != null) onEnterScreen();
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
		if (onExitScreen != null) onExitScreen();
	}

	

	private void SetEnterStatus()
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	protected override void DoDispose()
	{
	}

	private void setStatusWrapper(string oldBtnName, string newBtnName)
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}

	public bool IsInRefineConfirmUI()
	{
		return false;
	}
}
