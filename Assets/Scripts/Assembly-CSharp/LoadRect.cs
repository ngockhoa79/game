using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("SquanderGuidance")]
public class LoadRect : FsmStateAction
{
	private Init init;

	public bool EnableMask;

	public Vector2 CenterPoint;

	public float ViewPortWidth;

	public float ViewPortHeight;

	private const int ValidWidth = 9600;

	private const int ValidHeight = 6400;

	private float halfValidWidth;

	private float halfValidHeight;

	private float halfViewPortWidth;

	private float halfViewPortHeight;

	public bool Anchor;

	public bool IsLeftAnchor;

	public override void OnEnter()
	{
	}

	private void clamp()
	{
	}

	private void createMasking()
	{
	}

	private void createMeshCollider()
	{
	}

	public override void OnExit()
	{
	}
}
