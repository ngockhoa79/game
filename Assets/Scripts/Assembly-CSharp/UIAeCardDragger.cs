using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIAeCardDragger : IceUIDragItem
{
	public UIAeCardDisplayer Portrait;

	public MovementAnimator Mover;

	public QuaternionRotationAnimator Shaker;

	public float ShakeDegree;

	public Hero Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIAeSlot ParentSlot => null;

	public void DisableCollider()
	{
	}

	public void Shake()
	{
	}

	public void StopShake()
	{
	}

	public void MoveTo(Vector3 targetPos, Action<UIAeCardDragger> callback = null)
	{
	}

	public void ResetPos(Action<UIAeCardDragger> callback = null, bool playEffect = true)
	{
	}

	public void ResetPosUsingOffset(Vector3 offset, Action<UIAeCardDragger> callback = null, bool playEffect = true)
	{
	}

	public void Activate(bool isActive)
	{
	}

	public void Dispose()
	{
	}
}
