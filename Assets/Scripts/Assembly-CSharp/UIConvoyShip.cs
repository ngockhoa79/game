using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIConvoyShip : IceUIBase
{
	[SerializeField]
	private GameObject Ship;

	[SerializeField]
	private IceAnimatorTotalCommander ShipAni;

	[SerializeField]
	private UIEventListener SelectButton;

	[SerializeField]
	public UIDragObject dragObj;

	[SerializeField]
	private UISprite nameBG;

	[SerializeField]
	private UISprite nameSplitter;

	[SerializeField]
	private UISprite encourageIcon;

	[SerializeField]
	private UILabel textEncourageValue;

	[SerializeField]
	private UILabel textName;

	[SerializeField]
	private UILabel textGold;

	[SerializeField]
	private UILabel textTimeLeft;

	public IceAnimatorTotalCommander BodyGuardAni;

	public Action<EscortLobbyData> OnViewShip;

	public Action<Vector2> OnDragShip;

	public Action<Vector3, int> OnMoneyChange;

	public float realDistance;

	public int ShipID;

	public float RealSpeed;

	public float DataSpeed;

	public int OriginalBaseGold;

	public int OriginalAdditionalGold;

	private double DistanceToRecalc;

	private double MoneyDecreaseRate;

	private int MoneyBaseDecrease;

	private int MoneyAdditionalDecrease;

	private double DistanceAccumulator;

	public EscortLobbyData ShipData { get; private set; }

	public double RunningDistance { get; private set; }

	public void SetData(EscortLobbyData data, float realDistance, int escortDistance, int depth = 0)
	{
	}

	public void UpdateEncourageInfo(int encourageValue, int encourageCount)
	{
	}

	public void UpdateBoostInfo(float boostValue, int speedCode)
	{
	}

	public void SetShipTimeLeft(string timeLeft)
	{
	}

	public bool isMyShip()
	{
		return false;
	}

	public void OnSecondUpdater()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}
}
