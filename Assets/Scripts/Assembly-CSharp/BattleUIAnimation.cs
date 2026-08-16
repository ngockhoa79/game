using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class BattleUIAnimation : FsmStateAction
{
	[RequiredField]
	public BattleUIAnimationType type;

	[RequiredField]
	public FsmBool active;

	private BattleCameraCtrller camCtrller;

	public override void OnEnter()
	{
	}
}
