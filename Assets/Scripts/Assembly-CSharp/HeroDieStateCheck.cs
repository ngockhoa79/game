using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class HeroDieStateCheck : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmEvent toBlink;

	[RequiredField]
	public FsmEvent toNormalDie;

	public override void OnEnter()
	{
	}

	private bool needDieAnimation(string _state)
	{
		return false;
	}
}
