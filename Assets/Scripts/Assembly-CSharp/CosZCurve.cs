using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class CosZCurve : FsmStateAction
{
	[RequiredField]
	public FsmGameObject target;

	[RequiredField]
	public FsmFloat totalTime;

	[RequiredField]
	public FsmFloat ZMax;

	[RequiredField]
	public FsmAnimationCurve curveZ;

	private bool active;

	private float timer;

	private float process;

	private float originZ;

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
