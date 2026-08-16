using System;
using Ice.ProjectCos.UI.DataModel;

public class UICardItemGroup : IceUIBase
{
	public UICardItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public void SetData(Hero _hero1, Hero _hero2, CardBagManager.UIStatus _status, bool inMultiSelector)
	{
	}

	public void SetData(Hero _hero1, Hero _hero2, bool inMultiSelector)
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
