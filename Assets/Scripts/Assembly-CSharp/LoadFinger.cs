using System;
using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("SquanderGuidance")]
public class LoadFinger : FsmStateAction
{
	public enum FingerDirectionType
	{
		TopLeft = 1,
		TopRight = 2,
		BottomLeft = 3,
		BottomRight = 4
	}

	public enum FingerAnimatedType
	{
		None = 0,
		Clicking = 1,
		Dragging = 2
	}

	private Init init;

	private const string StaticFinger = "finger_2";

	private const float AnchorDelta58 = 58f;

	public Vector2 FingerPosition;

	public FingerAnimatedType AnimatedType;

	public bool Anchor;

	public bool IsLeftAnchor;

	private string storedName;

	public override void OnEnter()
	{
	}

	private void setupFinger()
	{
	}

	private void directFinger(int d)
	{
	}

	private void anchorFinger()
	{
	}

	private void activateFinger(bool active)
	{
	}

	private void animator(UISprite noneAnimatedFinger, IceAnimatorTotalCommander clickingFinger, IceAnimatorTotalCommander draggingFinger, Action onDeferred)
	{
	}

	public override void OnExit()
	{
	}

	public void ActivateFinger(bool active)
	{
	}
}
