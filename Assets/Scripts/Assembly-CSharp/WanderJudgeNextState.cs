using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class WanderJudgeNextState : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmFloat minMoveDistance;

	[RequiredField]
	public FsmFloat totalMoveDistance;

	[RequiredField]
	public FsmEvent moveEvent;

	[RequiredField]
	public FsmEvent stayEvent;

	private const float moveRate = 0.5f;

	private const float friendMoveRate = 0.3f;

	public override void OnEnter()
	{
	}
}
