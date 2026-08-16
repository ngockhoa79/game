using System;
using Ice.ProjectCos.UI.DataModel;

public class UIGearItemGroup : IceUIBase
{
	public UIGearItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public Action<ItemHolding> OnUnload;

	public void SetData(ItemHolding _gear1, ItemHolding _gear2, CardBagManager.UIStatus _status, bool inMultiSelector)
	{
	}

	public void SetData(ItemHolding _gear1, ItemHolding _gear2, bool inMultiSelector)
	{
	}

	public void SetDataWithUnload()
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
