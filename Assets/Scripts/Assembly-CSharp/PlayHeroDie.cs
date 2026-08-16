using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class PlayHeroDie : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmFloat totalTime;

	[RequiredField]
	public FsmAnimationCurve dieCurve;

	private float timer;

	private float process;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SetHeroColor()
	{
	}
}
