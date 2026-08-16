using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag and Drop Item")]
public class UIDragDropItem : MonoBehaviour
{
	public enum Restriction
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		PressAndHold = 3
	}

	[CompilerGenerated]
	private sealed class _003CEnableDragScrollView_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIDragDropItem _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CEnableDragScrollView_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public Restriction restriction;

	public bool cloneOnDrag;

	[HideInInspector]
	public float pressAndHoldDelay;

	public bool interactable;

	[NonSerialized]
	protected Transform mTrans;

	[NonSerialized]
	protected Transform mParent;

	[NonSerialized]
	protected Collider mCollider;

	[NonSerialized]
	protected Collider2D mCollider2D;

	[NonSerialized]
	protected UIButton mButton;

	[NonSerialized]
	protected UIRoot mRoot;

	[NonSerialized]
	protected UIGrid mGrid;

	[NonSerialized]
	protected UITable mTable;

	[NonSerialized]
	protected float mDragStartTime;

	[NonSerialized]
	protected UIDragScrollView mDragScrollView;

	[NonSerialized]
	protected bool mPressed;

	[NonSerialized]
	protected bool mDragging;

	[NonSerialized]
	protected UICamera.MouseOrTouch mTouch;

	protected virtual void Start()
	{
	}

	protected virtual void OnPress(bool isPressed)
	{
	}

	protected virtual void Update()
	{
	}

	protected virtual void OnDragStart()
	{
	}

	protected virtual void StartDragging()
	{
	}

	protected virtual void OnDrag(Vector2 delta)
	{
	}

	protected virtual void OnDragEnd()
	{
	}

	public void StopDragging(GameObject go)
	{
	}

	protected virtual void OnDragDropStart()
	{
	}

	protected virtual void OnDragDropMove(Vector2 delta)
	{
	}

	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	protected virtual void OnDragDropEnd()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableDragScrollView_003Ed__30))]
	protected IEnumerator EnableDragScrollView()
	{
		return null;
	}
}
