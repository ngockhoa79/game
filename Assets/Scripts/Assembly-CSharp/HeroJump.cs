using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class HeroJump : FsmStateAction
{
	[RequiredField]
	public FsmGameObject main;

	public FsmGameObject target;

	public FsmVector3 targetPos;

	[RequiredField]
	public FsmFloat time;

	[RequiredField]
	public FsmFloat distance;

	[RequiredField]
	public FsmFloat height;

	private float timer;

	private float vx;

	private float vy;

	private float g;

	private bool isLeft;

	private bool active;

	private bool onGround;

	private Vector3 heroInitPosition;

	private float targetX;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void UpdatePosition()
	{
	}
}
