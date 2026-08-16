using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class GetMoveSpeed : FsmStateAction
{
	[RequiredField]
	public BattleMoveType moveType;

	[RequiredField]
	public FsmFloat speed;

	public override void OnEnter()
	{
	}
}
