using System;
using Ice.ProjectCos.UI.DataModel;

public class UILgSkillUpgradeSuccess : IceUIBase
{
	public UniIcon Icon;

	public UICmStarDisplayer Star;

	public UILabel DescTextCurr;

	public UIEventListener Button;

	private SkillHolding holding;

	public Action OnClose;

	public IceAnimatorTotalCommander enterAnim;

	public SkillHolding Holding
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void clear()
	{
	}

	private void set(SkillHolding holding)
	{
	}

	public void SetData(SkillHolding org, SkillHolding curr)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}
