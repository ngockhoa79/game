using System.Collections.Generic;
using UnityEngine;

public class IceUIDragItem : MonoBehaviour
{
	public delegate void VoidDelegate(IceUIDragItem item);

	public delegate void IntDelegate(IceUIDragItem item, int slotIndex);

	public readonly List<BoxCollider> Slots;

	public readonly List<BoxCollider> FallBackSlots;

	private bool boxColliderEnable;

	public VoidDelegate OnPressed;

	public VoidDelegate OnDragging;

	public VoidDelegate OnReleased;

	public VoidDelegate OnClicked;

	public IntDelegate OnEnterSlot;

	public IntDelegate OnHoverSlot;

	public IntDelegate OnLeaveSlot;

	public IntDelegate OnEnterFallBackSlot;

	public IntDelegate OnHoverFallBackSlot;

	public IntDelegate OnLeaveFallBackSlot;

	public IntDelegate OnPutIntoSlot;

	public IntDelegate OnFallBack;

	public VoidDelegate OnInvalidDrag;

	private Vector3 dragStartPos;

	private int hoveringSlotIdx;

	private int hoveringFallBackIdx;

	private bool dragged;

	public bool BoxColliderEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Vector3 DraggingStartPos => default(Vector3);

	public int HoveringSlotIndex => 0;

	public int HoveringFallBackSlotIndex => 0;

	private void prepareWidgets()
	{
	}

	public int CollisionDetection(out int slotIdx, out int fallBackSlotIdx)
	{
		slotIdx = default(int);
		fallBackSlotIdx = default(int);
		return 0;
	}

	private void OnPress(bool pressed)
	{
	}

	private void OnDrag(Vector2 delta)
	{
	}

	private void Start()
	{
	}
}
