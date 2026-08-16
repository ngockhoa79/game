using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IceUIButton : MonoBehaviour
{
	public delegate void EventHandler();

	private UIEventListener listener;

	public string EffectResCategory;

	public string PressScalingEffect;

	public string ReleaseScalingEffect;

	private readonly List<AbstractAnimator> playingEffects;

	public Color EnabledColor;

	public Color DisabledColor;

	public event EventHandler OnClick
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private AbstractAnimator LoadEffect(string res)
	{
		return null;
	}

	private void stopAllEffects()
	{
	}

	private void playEffect(AbstractAnimator effect)
	{
	}

	public void InitEffects()
	{
	}

	private void prepareWidgets()
	{
	}

	public void SetEnabled(bool enabled)
	{
	}

	private void Start()
	{
	}
}
