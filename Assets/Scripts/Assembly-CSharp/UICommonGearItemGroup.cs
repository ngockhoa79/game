using System;
using Ice.ProjectCos.UI.DataModel;

public class UICommonGearItemGroup : IceUIBase
{
	public UICommonGearItem[] itemGroup;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public void SetItem1Data(ItemHolding gear, UICommonGearItem.EState state = UICommonGearItem.EState.Idle, UICommonGearItem.EMode mode = UICommonGearItem.EMode.NormalMode)
	{
	}

	public void SetItem2Data(ItemHolding gear, UICommonGearItem.EState state = UICommonGearItem.EState.Idle, UICommonGearItem.EMode mode = UICommonGearItem.EMode.NormalMode)
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
