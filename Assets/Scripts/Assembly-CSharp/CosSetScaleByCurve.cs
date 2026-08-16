using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE")]
public class CosSetScaleByCurve : FsmStateAction
{
	[RequiredField]
	public FsmGameObject target;

	[RequiredField]
	public FsmFloat totalTime;

	[RequiredField]
	public FsmBool scaleX;

	[RequiredField]
	public FsmBool scaleY;

	[RequiredField]
	public FsmFloat ScaleMin;

	[RequiredField]
	public FsmFloat ScaleMax;

	[RequiredField]
	public FsmAnimationCurve scaleCurve;

	private float timer;

	private float process;

	private bool active;

	private Vector3 initScale;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void UpdateTargetScale()
	{
	}
}
