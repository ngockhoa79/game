using System;
using UnityEngine;

[RequireComponent(typeof(UIDragObject))]
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(UIEventListener))]
public class SwapBaseComponent : MonoBehaviour
{
	protected enum EState
	{
		Idle = 0,
		Dragging = 1,
		Intersected = 2,
		AutoMoving = 3
	}

	protected float animation_time;

	public Action<SwapBaseComponent> E_OnSwapStart;

	public Action<SwapBaseComponent> E_OnSwapFinish;

	protected UIEventListener myEventListener;

	protected UIDragObject myDragObject;

	protected bool bSelected;

	private bool bSwappingTarget;

	protected Vector3 initPos;

	private Vector3 movingStartPos;

	private Vector3 movingEndPos;

	private float timePassed;

	protected SwapBaseComponent intersectObj;

	protected SwapBaseComponent swapObj;

	private EState State;

	public Vector3 MyPosition => default(Vector3);

	protected virtual void OnSwapEnter(SwapBaseComponent target)
	{
	}

	protected virtual void OnSwapStay(SwapBaseComponent target)
	{
	}

	protected virtual void OnSwapExit(SwapBaseComponent target)
	{
	}

	protected virtual void Clean()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnCollisionEnter(Collision target)
	{
	}

	private void OnCollisionExit(Collision target)
	{
	}

	protected void PressUpObject()
	{
	}

	protected void SetState(EState tarState)
	{
	}

	public void MoveToTargetPosition(Vector3 targetPosition, SwapBaseComponent target)
	{
	}

	private void Update()
	{
	}
}
