using System;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILgSkillDisplayer : IceUIBase
{
	public enum EMode
	{
		View = 0,
		Sell = 1,
		Select = 2
	}

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public UILabel NameText;

	public UICmStarDisplayer Star;

	public UICmSkillIcon Icon;

	public GameObject UserNode;

	public UIAeCardDisplayer UserIcon;

	public UILabel DescText;

	public GameObject PriceNode;

	public UILabel PriceText;

	public UIEventListener UpgradeButton;

	public IceUIToggleButton CheckBox;

	public UIEventListener SelectButton;

	public UIEventListener eventRoot;

	public Action<ItemHolding> OnViewHolding;

	public EMode Mode { get; private set; }

	public SkillHolding Holding { get; private set; }

	public event Action<SkillHolding> OnUpgrade
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

	public event Action<SkillHolding, bool> OnSelect
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

	private void set(SkillHolding holding, EMode mode, bool isSelected)
	{
	}

	public void Set(SkillHolding holding, EMode mode, bool isSelected)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	public void OnIconClick()
	{
	}
}
