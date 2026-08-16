using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE_Art")]
public class CosRotation : FsmStateAction
{
	protected new enum State
	{
		Delay = 0,
		Animating = 1,
		Stop = 2
	}

	[RequiredField]
	public GameObject targetObject;

	[RequiredField]
	public FsmVector3 targetEularRotation;

	[RequiredField]
	public FsmFloat delay;

	[RequiredField]
	public FsmFloat timeLast;

	private Vector3 _initEularRotation;

	private float _timePassed;

	protected State _state;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private bool Animate()
	{
		return false;
	}
}
