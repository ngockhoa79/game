using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class WanderTargetPositionSet : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmVector3 targetPosition;

	[RequiredField]
	public FsmFloat totalMoveDistance;

	public override void OnEnter()
	{
	}
}
