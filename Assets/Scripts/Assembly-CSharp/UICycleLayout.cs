using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Cycle Layout By WangXiao")]
public class UICycleLayout : UIWidgetContainer
{
	public enum Sorting
	{
		None = 0,
		Alphabetic = 1,
		Horizontal = 2,
		Vertical = 3,
		Custom = 4
	}

	public enum Direction
	{
		CW = 0,
		CCW = 1
	}

	public delegate void OnReposition();

	public float DistanceToCenter;

	public float OffsetDegree;

	public bool keepWithinPanel;

	public bool hideInactive;

	public Direction LayoutDirection;

	public Sorting sorting;

	[HideInInspector]
	[SerializeField]
	private bool sorted;

	protected bool mReposition;

	protected UIPanel mPanel;

	protected bool mInitDone;

	public OnReposition onReposition;

	protected virtual void Init()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public static int SortByName(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortHorizontal(Transform a, Transform b)
	{
		return 0;
	}

	public static int SortVertical(Transform a, Transform b)
	{
		return 0;
	}

	protected virtual void Sort(BetterList<Transform> list)
	{
	}

	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
	}

	public List<Transform> GetShowingChildren()
	{
		return null;
	}
}
