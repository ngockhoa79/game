using System;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;

public class UILgMiscDisplayer : IceUIBase
{
	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public UICmItemIcon Icon;

	public UILabel NameText;

	public UILabel DescText;

	public IceUIButton UseButton;

	public const int FAST_USE_COUNT = 10;

	public UIEventListener eventRoot;

	public Action<ItemHolding> OnViewHolding;

	private ItemHolding holding;

	public ItemHolding Holding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event Action OnBadUse
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

	private void set(ItemHolding holding)
	{
	}

	private void fireEvent(int count)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}
}
