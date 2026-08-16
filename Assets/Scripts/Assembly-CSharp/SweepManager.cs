using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class SweepManager
{
	public enum EType
	{
		None = 0,
		Sweep = 1,
		Battle = 2,
		_NUM = 3
	}

	public Action UpdateInfo;

	private EType sweepType;

	private int duplicationID;

	private int chapterType;

	private int countLeft;

	private int remainSweepTimes;

	private int energy;

	private int dupEnergyReq;

	private int addLevelTimesPrice;

	private int addSweepTimesPrice;

	private int sweepTimes;

	private int dupLimitTimes;

	private int usableRemainSweepCount;

	private bool sweepResult;

	private bool isSweeped;

	private GameObject sweepMenuObj;

	private GameObject popupItemObj;

	private GameObject addLevelTimesMenuObj;

	private GameObject addSweepTimesMenuObj;

	private GameObject addEnergyMenuObj;

	private UISweepMenu sweepMenu;

	private UISweepResult popupItem;

	private UISimpleCrystalPaidMenu addLevelTimesMenu;

	private UISimpleCrystalPaidMenu addSweepTimesMenu;

	private UIAddEnergyEnsure addEnergyMenu;

	private Action BattleCallback;

	private List<DuplicateSettlementProto> Settlements;

	private int beforeLv;

	private int afterLv;

	public void SetStage(int duplicationID, int chapterType, EType type, Action callback = null)
	{
	}

	private void CheckCountLeft()
	{
	}

	private void CheckSweepTimes()
	{
	}

	private void CheckEnergy()
	{
	}

	private void PopupSweepMenu(bool bCalculateEnergy = true)
	{
	}

	private void OnSweepMenuEntered()
	{
	}

	private void OnSweepMenuBuySweepTimes(int buyTimes)
	{
	}

	private void OnSweepMenuBuyEnergy(int energy)
	{
	}

	private void OnSweepResponsed(bool result)
	{
	}

	private void OnSweepMenuClosed()
	{
	}

	private void SetPopupItem()
	{
	}

	private void OnPopupItemEntered()
	{
	}

	private void OnPopupItemClosed()
	{
	}

	private void SetAddLevelTimesMenu()
	{
	}

	private void OnAddLevelTimesEntered()
	{
	}

	private void OnAddLevelTimesEnsure()
	{
	}

	private void OnAddLevelTimesResponse(object response)
	{
	}

	private void OnAddLevelTimesCancel()
	{
	}

	private void OnAddLevelTimesMenuClosed()
	{
	}

	private void OnAddLevelTimesMenuClear()
	{
	}

	private void SetAddSweepTimesMenu(int buyTimes)
	{
	}

	private void OnAddSweepTimesEntered()
	{
	}

	private void OnAddSweepTimesEnsure()
	{
	}

	private void OnSweepResponse(object response)
	{
	}

	private void OnAddSweepTimesResponse(object response)
	{
	}

	private void OnAddSweepTimesCancel()
	{
	}

	private void OnAddSweepTimesMenuClosed()
	{
	}

	private void OnAddSweepTimesMenuClear()
	{
	}

	public void ShowDialogGotoCharge(string tag, string msg)
	{
	}

	private void SetAddEnergyMenu()
	{
	}

	private void OnAddEnergyEntered()
	{
	}

	private void OnAddEnergyEnsure()
	{
	}

	private void OnAddEnergyResponse(object response)
	{
	}

	private void OnAddEnergyCancel()
	{
	}

	private void OnAddEnergyRejected()
	{
	}

	private void OnAddEnergyMenuClosed()
	{
	}

	private void OnAddEnergyMenuClear()
	{
	}
}
