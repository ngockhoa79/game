using System;

public class UILgFailurePrompt : IceUIBase
{
	public UILabel CauseText;

	public string Cause
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}
