using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class CheckHeroStartState : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	private PlayMakerFSM heroFsm;

	private bool needStandup;

	private float timer;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	public override void OnLateUpdate()
	{
	}

	private void AddAnimationEndListener()
	{
	}

	private void OnAnimationEndEvent()
	{
	}

	private bool isStandingUp()
	{
		return false;
	}
}
