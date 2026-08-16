using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Scale")]
public class TweenScale : UITweener
{
	public Vector3 from;

	public Vector3 to;

	public bool updateTable;

	private Transform mTrans;

	private UITable mTable;

	public Transform cachedTransform => null;

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

	[Obsolete("Use 'value' instead")]
	public Vector3 scale
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenScale Begin(GameObject go, float duration, Vector3 scale)
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
