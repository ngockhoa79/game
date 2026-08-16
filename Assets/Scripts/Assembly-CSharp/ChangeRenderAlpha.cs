using HutongGames.PlayMaker;
using UnityEngine;

[ActionCategory("ICEE_Art")]
public class ChangeRenderAlpha : FsmStateAction
{
	[RequiredField]
	public FsmGameObject target;

	[RequiredField]
	public FsmFloat alphaFrom;

	[RequiredField]
	public FsmFloat alphaTo;

	[RequiredField]
	public FsmFloat time;

	public FsmEvent FinishEvent;

	private Material material;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}
}
