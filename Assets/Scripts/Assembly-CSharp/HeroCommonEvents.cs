using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class HeroCommonEvents : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public HeroCommonFsmEvents stateEvent;

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
