using System;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/NGUI Scroll Bar")]
[ExecuteInEditMode]
public class UIScrollBar : UISlider
{
	private enum Direction
	{
		Horizontal = 0,
		Vertical = 1,
		Upgraded = 2
	}

	[SerializeField]
	[HideInInspector]
	protected float mSize;

	[HideInInspector]
	[SerializeField]
	private float mScroll;

	[SerializeField]
	[HideInInspector]
	private Direction mDir;

	[Obsolete("Use 'value' instead")]
	public float scrollValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float barSize
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected override void Upgrade()
	{
	}

	protected override void OnStart()
	{
	}

	protected override float LocalToValue(Vector2 localPos)
	{
		return 0f;
	}

	public override void ForceUpdate()
	{
	}
}
