using System;
using Ice.ProjectCos.UI.DataModel;

public class UIItemItemGroup : IceUIBase
{
	public UIItemItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public void SetData(ItemHolding _item1, ItemHolding _item2)
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
