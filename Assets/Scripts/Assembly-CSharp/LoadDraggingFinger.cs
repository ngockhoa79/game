using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("SquanderGuidance")]
public class LoadDraggingFinger : FsmStateAction
{
	public enum FingerAnimatedType
	{
		None = 0,
		Clicking = 1,
		Dragging = 2
	}

	private Init init;

	private const string StaticFinger = "finger_2";

	public Vector2 FingerPosition;

	public FingerAnimatedType AnimatedType;

	public static GameObject InitFinger;

	public override void OnEnter()
	{
	}

	private void setupFinger()
	{
	}

	public override void OnExit()
	{
	}
}
