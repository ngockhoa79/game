using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class CosSetPosByCurve : FsmStateAction
{
	[RequiredField]
	public FsmGameObject target;

	[RequiredField]
	public FsmFloat totalTime;

	[RequiredField]
	public FsmBool enableX;

	[RequiredField]
	public FsmFloat XMax;

	[RequiredField]
	public FsmAnimationCurve curveX;

	[RequiredField]
	public FsmBool XFlip;

	[RequiredField]
	public FsmBool enableY;

	[RequiredField]
	public FsmFloat YMax;

	[RequiredField]
	public FsmAnimationCurve curveY;

	private int direction;

	private float timer;

	private float process;

	private bool active;

	private Vector3 initPosition;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void UpdateTargetPosition()
	{
	}
}
