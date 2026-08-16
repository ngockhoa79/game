using System;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Color")]
public class TweenColor : UITweener
{
	public Color from;

	public Color to;

	private bool mCached;

	private UIWidget mWidget;

	private Material mMat;

	private Light mLight;

	private SpriteRenderer mSr;

	[Obsolete("Use 'value' instead")]
	public Color color
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public Color value
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	private void Cache()
	{
	}

	protected override void OnUpdate(float factor, bool isFinished)
	{
	}

	public static TweenColor Begin(GameObject go, float duration, Color color)
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
