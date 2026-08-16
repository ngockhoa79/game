using System;

public class UIMainSceneCardPanel : IceUIBase
{
	public UIEventListener btnCard;

	public UIEventListener btnParty;

	public Action E_OnCard;

	public Action E_OnParty;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}
