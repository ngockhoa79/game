using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class EventsByHeroSide : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmEvent leftEvent;

	[RequiredField]
	public FsmEvent rightEvent;

	[RequiredField]
	public FsmFloat delay;

	private BattleCameraCtrller camCtrller;

	private float timer;

	private bool setOver;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void GoEvent()
	{
	}
}
