using System;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("NGUI/Tween/Tween Field of View")]
public class TweenFOV : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera => null;

	[Obsolete("Use 'value' instead")]
	public float fov
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

	public static TweenFOV Begin(GameObject go, float duration, float to)
	{
		return null;
	}

	[ContextMenu("Set 'From' to current value")]
	public override void SetStartToCurrentValue()
	{
	}

	[ContextMenu("Set 'To' to current value")]
	public override void SetEndToCurrentValue()
	{
	}

	[ContextMenu("Assume value of 'From'")]
	private void SetCurrentValueToStart()
	{
	}

	[ContextMenu("Assume value of 'To'")]
	private void SetCurrentValueToEnd()
	{
	}
}
