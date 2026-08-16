using System;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;

public class UILgSkillSacrificeSelector : IceUIBase
{
	public UILabel NameText;

	public UILabel UsageText;

	public UICmSkillIcon SkillIcon;

	public UICmItemIcon StoneIcon;

	public UICmStarDisplayer Star;

	public UIEventListener MinusButton;

	public Func<bool> IsIncresable;

	public ItemHolding Holding { get; private set; }

	public int Usage { get; private set; }

	public event Action<ItemHolding, int> OnUsageChanged
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

	private void clear()
	{
	}

	private void set(ItemHolding holding, int usage)
	{
	}

	private void updateUsageText()
	{
	}

	public void Set(ItemHolding holding, int usage)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void OnClick()
	{
	}
}
