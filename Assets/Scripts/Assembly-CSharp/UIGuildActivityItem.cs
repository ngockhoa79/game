using System;

public class UIGuildActivityItem : IceUIBase
{
	public UILabel lbMessage;

	public UILabel lbLastTime;

	public UIAeCardDisplayer CardDisplay;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	protected GuildActivityData actData;

	protected override void DoInit()
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

	public void Clear()
	{
	}

	public void SetData(GuildActivityData data)
	{
	}
}
