using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[AddComponentMenu("NGUI/Tween/Tween Volume")]
public class TweenVolume : UITweener
{
	[Range(0f, 1f)]
	public float from;

	[Range(0f, 1f)]
	public float to;

	private AudioSource mSource;

	public AudioSource audioSource => null;

	[Obsolete("Use 'value' instead")]
	public float volume
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float value
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
	{
		return null;
	}

	public override void SetStartToCurrentValue()
	{
	}

	public override void SetEndToCurrentValue()
	{
	}
}
