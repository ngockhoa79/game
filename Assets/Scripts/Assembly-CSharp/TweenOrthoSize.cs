using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Orthographic Size")]
[RequireComponent(typeof(Camera))]
public class TweenOrthoSize : UITweener
{
	public float from;

	public float to;

	private Camera mCam;

	public Camera cachedCamera => null;

	[Obsolete("Use 'value' instead")]
	public float orthoSize
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

	public static TweenOrthoSize Begin(GameObject go, float duration, float to)
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
