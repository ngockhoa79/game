using System;

public class UIMainSceneSocial : IceUIBase
{
	public UIEventListener btnFriend;

	public UIEventListener btnGuild;

	public Action E_OnFriend;

	public Action E_OnGuild;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	protected override void DoPrepare()
	{
		if (btnFriend != null)
		{
			btnFriend.onClick = (go) => { if (E_OnFriend != null) E_OnFriend(); };
		}
		if (btnGuild != null)
		{
			btnGuild.onClick = (go) => { if (E_OnGuild != null) E_OnGuild(); };
		}
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
		if (onEnterScreen != null) onEnterScreen();
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
		if (onExitScreen != null) onExitScreen();
	}
}
