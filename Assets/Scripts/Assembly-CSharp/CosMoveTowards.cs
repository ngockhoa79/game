using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class CosMoveTowards : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	public FsmGameObject targetObject;

	public FsmVector3 targetPosition;

	public FsmFloat maxSpeed;

	public FsmFloat finishDistance;

	public FsmEvent finishEvent;

	public FsmBool ignoreVertical;

	private GameObject go;

	private GameObject goTarget;

	private Vector3 targetPos;

	private Vector3 offsetPos;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void DoMoveTowards()
	{
	}

	public bool UpdateTargetPos()
	{
		return false;
	}

	public Vector3 GetTargetPos()
	{
		return default(Vector3);
	}
}
