using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class HeroAttackEvents : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public HeroAttackFsmEvents attackEvent;

	[RequiredField]
	public FsmFloat delay;

	private float timer;

	private bool sendOver;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SendEvent()
	{
	}
}
