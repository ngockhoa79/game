using HutongGames.PlayMaker;

[ActionCategory("ICEE_Art")]
public class Tk2dAlphaCurve : FsmStateAction
{
	[RequiredField]
	public tk2dSprite target;

	[RequiredField]
	public FsmAnimationCurve curveA;

	[RequiredField]
	public FsmFloat time;

	[RequiredField]
	public FsmFloat delay;

	private float timer;

	private float delayTimer;

	private bool startSet;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void StartSet()
	{
	}

	private void SetAlpha()
	{
	}
}
