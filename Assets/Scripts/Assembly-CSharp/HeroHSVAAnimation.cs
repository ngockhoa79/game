using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class HeroHSVAAnimation : FsmStateAction
{
	public enum HeroHSVAType
	{
		H = 0,
		S = 1,
		V = 2,
		A = 3
	}

	[RequiredField]
	public FsmGameObject hero;

	public HeroHSVAType type;

	[RequiredField]
	public FsmFloat totalTime;

	[RequiredField]
	public FsmAnimationCurve animCurve;

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
