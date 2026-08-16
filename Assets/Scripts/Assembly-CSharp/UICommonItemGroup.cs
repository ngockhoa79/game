using System;
using Ice.ProjectCos.UI.DataModel;

public class UICommonItemGroup : IceUIBase
{
	public UICommonItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public void SetItem1(ItemHolding skill, UICommonItem.EState state = UICommonItem.EState.Idle, UICommonItem.EMode mode = UICommonItem.EMode.NormalMode)
	{
	}

	public void SetItem2(ItemHolding skill, UICommonItem.EState state = UICommonItem.EState.Idle, UICommonItem.EMode mode = UICommonItem.EMode.NormalMode)
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
