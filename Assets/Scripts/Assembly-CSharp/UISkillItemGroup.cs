using System;
using Ice.ProjectCos.UI.DataModel;

public class UISkillItemGroup : IceUIBase
{
	public UISkillItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public Action<ItemHolding> OnUnload;

	public void SetData(ItemHolding _skill1, ItemHolding _skill2, CardBagManager.UIStatus _status, bool inMultiSelector)
	{
	}

	public void SetData(ItemHolding _skill1, ItemHolding _skill2, bool inMultiSelector)
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
