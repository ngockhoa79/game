using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Position")]
public class TweenPosition : UITweener
{
	public Vector3 from;

	public Vector3 to;

	[HideInInspector]
	public bool worldSpace;

	private Transform mTrans;

	private UIRect mRect;

	public Transform cachedTransform => null;

	[Obsolete("Use 'value' instead")]
	public Vector3 position
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 value
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos)
	{
		return null;
	}

	public static TweenPosition Begin(GameObject go, float duration, Vector3 pos, bool worldSpace)
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
