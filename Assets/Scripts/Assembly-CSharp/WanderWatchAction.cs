using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class WanderWatchAction : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmVector3 targetPosition;

	[RequiredField]
	public FsmEvent watchEvent;

	private BattleHeroCtrller heroCtrller;

	private float timer;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}
}
