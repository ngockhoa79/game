using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class HeroJumpSky : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	public FsmGameObject targetObject;

	public FsmVector3 jumpTargetPos;

	public FsmBool fall;

	public FsmFloat xDistance;

	public FsmEvent finishEvent;

	public FsmFloat customJumpSpeed;

	private GameObject go;

	private float jumpUpSpeed;

	private float groundY;

	private float fallTimer;

	private float downTimer;

	private bool onGround;

	private int direction;

	private Vector3 heroInitPosition;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void DoJumpUp()
	{
	}

	private void DoJumpDown()
	{
	}

	private void JumpOver()
	{
	}
}
