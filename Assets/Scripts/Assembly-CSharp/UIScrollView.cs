using System;
using UnityEngine;

[RequireComponent(typeof(UIPanel))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Scroll View")]
public class UIScrollView : MonoBehaviour
{
	public enum Movement
	{
		Horizontal = 0,
		Vertical = 1,
		Unrestricted = 2,
		Custom = 3
	}

	public enum DragEffect
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2
	}

	public enum ShowCondition
	{
		Always = 0,
		OnlyIfNeeded = 1,
		WhenDragging = 2
	}

	public delegate void OnDragNotification();

	public static BetterList<UIScrollView> list;

	public Movement movement;

	public DragEffect dragEffect;

	public bool restrictWithinPanel;

	public bool disableDragIfFits;

	public bool smoothDragStart;

	public bool iOSDragEmulation;

	public float scrollWheelFactor;

	public float momentumAmount;

	public UIProgressBar horizontalScrollBar;

	public UIProgressBar verticalScrollBar;

	public ShowCondition showScrollBars;

	public Vector2 customMovement;

	public UIWidget.Pivot contentPivot;

	public OnDragNotification onDragStarted;

	public OnDragNotification onDragFinished;

	public OnDragNotification onMomentumMove;

	public OnDragNotification onStoppedMoving;

	public float sensitive;

	[HideInInspector]
	[SerializeField]
	private Vector3 scale;

	[SerializeField]
	[HideInInspector]
	private Vector2 relativePositionOnReset;

	protected Transform mTrans;

	protected UIPanel mPanel;

	protected Plane mPlane;

	protected Vector3 mLastPos;

	protected bool mPressed;

	protected Vector3 mMomentum;

	protected float mScroll;

	protected Bounds mBounds;

	protected bool mCalculatedBounds;

	protected bool mShouldMove;

	protected bool mIgnoreCallbacks;

	protected int mDragID;

	protected Vector2 mDragStartOffset;

	protected bool mDragStarted;

	[NonSerialized]
	private bool mStarted;

	[HideInInspector]
	public UICenterOnChild centerOnChild;

	public UIPanel panel => null;

	public bool isDragging => false;

	public virtual Bounds bounds => default(Bounds);

	public bool canMoveHorizontally => false;

	public bool canMoveVertically => false;

	public virtual bool shouldMoveHorizontally => false;

	public virtual bool shouldMoveVertically => false;

	protected virtual bool shouldMove => false;

	public Vector3 currentMomentum
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

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void CheckScrollbars()
	{
	}

	private void OnDisable()
	{
	}

	public bool RestrictWithinBounds(bool instant)
	{
		return false;
	}

	public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
	{
		return false;
	}

	public void DisableSpring()
	{
	}

	public void UpdateScrollbars()
	{
	}

	public virtual void UpdateScrollbars(bool recalculateBounds)
	{
	}

	protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
	{
	}

	public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
	{
	}

	public void InvalidateBounds()
	{
	}

	[ContextMenu("Reset Clipping Position")]
	public void ResetPosition()
	{
	}

	public void UpdatePosition()
	{
	}

	public void OnScrollBar()
	{
	}

	public virtual void MoveRelative(Vector3 relative)
	{
	}

	public void MoveAbsolute(Vector3 absolute)
	{
	}

	public void Press(bool pressed)
	{
	}

	public void Drag()
	{
	}

	public void Scroll(float delta)
	{
	}

	private void LateUpdate()
	{
	}

	public void Reset()
	{
	}
}
