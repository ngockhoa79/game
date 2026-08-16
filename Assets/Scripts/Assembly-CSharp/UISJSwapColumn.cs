using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UISJColumnDisplayer))]
public class UISJSwapColumn : SwapBaseComponent
{
	public static List<UIDragObject> allDragList;

	public bool Dockable;

	private bool _dragable;

	public int pickedDepth;

	private bool _isPicked;

	public bool IsPicked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool Dragable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Clean()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	public void ForcePress(bool pressed)
	{
	}

	private void OnPress(bool isPressed)
	{
	}

	private void OnCollisionEnter(Collision target)
	{
	}
}
