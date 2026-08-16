using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class HeroGetHitEvents : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public HeroGetHitFsmEvents hitEvent;

	public FsmEvent hurtFsmEvent;

	public FsmEvent blockFsmEvent;

	public FsmEvent dodgeFsmEvent;

	private HeroGetHitResultType resultHitEvent;

	public override void OnEnter()
	{
	}
}
