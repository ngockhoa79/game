using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILgGearStrengthener : IceUIBase
{
	public UI4GearDisplayer GearDisplayer;

	public UILabel DescText;

	public UILabel FromLevelText;

	public UILabel ToLevelText;

	public UISprite MajorBufIcon;

	public UISprite MajorBufSpec;

	public UILabel MajorBufFromValue;

	public UILabel MajorBufToValue;

	public UISprite LvArrow;

	public UISprite MajorArrow;

	public UILabel CostText;

	public UILabel CoinsText;

	public UIEventListener StrengthenButton;

	public UIEventListener SelectGearButton;

	public UIEventListener AutoStrengthenButton;

	public GameObject EmptySlot;

	public GameObject FullBody;

	public IceAnimatorTotalCommander clickAnimator;

	public IceAnimatorTotalCommander emptyAnimator;

	public IceAnimatorTotalCommander enableAnimator;

	public Action<GearHolding> OnStrengthen;

	public Action<GearHolding, int> OnAutoStrengthen;

	public Action<GearHolding, object> OnBadStrengthen;

	public Action OnSelectGear;

	private string ColorGreen;

	private string precondition;

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

	private void clear()
	{
	}

	private void set(GearHolding holding)
	{
	}

	private void SetMajorSprite()
	{
	}

	private void levelChangeListener(GearHolding holding, int oldLevel, int newLevel)
	{
	}

	protected override void DoInit()
	{
	}

	private void OnStrengthenClicked(GameObject obj)
	{
	}

	private void OnAutoStrengthenClicked(GameObject obj)
	{
	}

	private void OnSelectGearClicked(GameObject obj)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void Update()
	{
	}
}
