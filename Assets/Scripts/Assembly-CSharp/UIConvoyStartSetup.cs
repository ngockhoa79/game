using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIConvoyStartSetup : IceUIBase
{
	public UIConvoyStartSetupShip[] ShipPreview;

	public UISprite ShipName;

	public UILabel ShipBonus;

	public UILabel ShipUpgradePrice;

	public UILabel ShipUpgradeRate;

	public UILabel ConvoyLevel;

	public UILabel ConvoyExpStatus;

	public UILabel ConvoyExpGain;

	public UILabel ConvoyLevelBonus;

	public UISlider ConvoyExpBar;

	public UIEventListener ButtonStart;

	public UIEventListener ButtonUpgrade;

	public UIEventListener ButtonClose;

	public UIEventListener ButtonHelp;

	public UIEventListener ButtonSelectGuard;

	public GameObject GuardEmptyGroup;

	public GameObject GuardPlayerGroup;

	public UIAeSingleCardDisplayer GuardDisplayer;

	public UILabel GuardPlayerName;

	public UILabel GuardPower;

	public IceAnimatorTotalCommander StartExpExpAni;

	public IceAnimatorTotalCommander RateUpAni;

	public IceAnimatorTotalCommander[] ShipUpgradedAni;

	public Action OnReturn;

	public Action OnSelectGuard;

	public Action<EscortTargetProto> OnStartSuccess;

	public Action<int, int> OnShipUpdated;

	private int currentShipID;

	private int previousShipID;

	private int previousSuccessRate;

	private int shipUpgradePrice;

	private const string cColorYellow = "[fff000]";

	private const string cColorBlue = "[7afffe]";

	private const string cColorRed = "[d10203]";

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	public void SetData(int shipID, int successRate)
	{
	}

	public void OnButtonStartClick(GameObject buttonClicked)
	{
	}

	public void OnButtonUpgradeClick(GameObject buttonClicked)
	{
	}

	public void OnButtonSelectGuardClick(GameObject buttonClicked)
	{
	}

	public void OnButtonHelpClick(GameObject buttonClicked)
	{
	}

	public void OnButtonCloseClick(GameObject buttonClicked)
	{
	}
}
