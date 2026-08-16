using System;
using Ice.ProjectCos.UI.DataModel;

public class UIGearFragGroup : IceUIBase
{
	public UIGearFragmentItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public void SetData(ItemHolding _gearfrag1, ItemHolding _gearfrag2)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}
}
