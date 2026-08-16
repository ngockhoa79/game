using System;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILgGearDisplayer : IceUIBase
{
	public enum EMode
	{
		View = 0,
		Sell = 1,
		Select = 2
	}

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public UILabel LevelText;

	public UILabel NameText;

	public UICmItemIcon Icon;

	public GameObject UserNode;

	public UIAeCardDisplayer UserIcon;

	public GameObject BufSpecNode;

	public UISprite MajorBufIcon;

	public UISprite MajorBufSpec;

	public UILabel MajorBufValue;

	public GameObject ForgeReqNode;

	public UILabel ForgeReqText;

	public GameObject PriceNode;

	public UILabel PriceText;

	public UIEventListener ForgeButton;

	public UIEventListener StrengthenButton;

	public IceUIToggleButton SellCheckBox;

	public UIEventListener SelectButton;

	public UIEventListener PopupButton;

	public Action<ItemHolding> OnPopup;

	private string ColorRed;

	private string ColorGreen;

	public Action<ItemHolding> OnViewHolding;

	public EMode Mode { get; private set; }

	public ItemHolding Holding { get; private set; }

	public bool IsSelected { get; private set; }

	public event Action<ItemHolding> OnComplement
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ItemHolding> OnForge
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<GearHolding> OnStrengthen
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<ItemHolding, bool> OnSelect
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void clear()
	{
	}

	private void set(ItemHolding holding, EMode mode, bool isSelected)
	{
	}

	private void listener(ThingHolding a, int b, int c)
	{
	}

	private void dispForge(ItemHolding holding)
	{
	}

	private void dispGear(GearHolding holding)
	{
	}

	private void dispSell(ItemHolding holding, bool isSelected)
	{
	}

	private void dispSelect(GearHolding holding)
	{
	}

	public void Set(ItemHolding holding, EMode mode, bool isSelected)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	public void OnPopupClicked(GameObject obj)
	{
	}

	public void OnIconClick()
	{
	}
}
