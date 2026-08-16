using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class CosShakeCamera : FsmStateAction
{
	[RequiredField]
	public FsmFloat shakeTime;

	[RequiredField]
	public FsmVector3 shakePos;

	[RequiredField]
	public FsmBool shakeUI;

	[RequiredField]
	public FsmFloat delay;

	private float timer;

	private bool setOver;

	private Camera go;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void Shake()
	{
	}
}
