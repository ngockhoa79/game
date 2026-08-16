using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class CosMoveByTime : FsmStateAction
{
	[RequiredField]
	public FsmGameObject moveObject;

	public FsmGameObject targetObject;

	public FsmVector3 offset;

	public FsmFloat time;

	public FsmFloat finishDistance;

	public FsmFloat delay;

	private GameObject go;

	private GameObject goTarget;

	private float speed;

	private Vector3 targetPos;

	private float delayTimer;

	private bool started;

	private float topZ;

	private Vector2 goPlanePos;

	private Vector2 targetPlanePos;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void DoMoveTowards()
	{
	}
}
