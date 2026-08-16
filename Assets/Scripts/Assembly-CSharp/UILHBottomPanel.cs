using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class UILHBottomPanel : IceUIBase
{
	public UILHAddSlot[] slots;

	public Action<int> E_OnSelect;

	public void SetData(List<ItemHolding> thingHoldings)
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

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	public void Clear()
	{
	}
}
