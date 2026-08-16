using System;
using Ice.ProjectCos.UI.DataModel;

public class UICardFragmentItemGroup : IceUIBase
{
	public UICardFragmentItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public UIDragScrollView Dragger;

	public void SetData(ItemHolding _heroFragment1, ItemHolding _heroFragment2)
	{
	}

	public void LoadTexture()
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
