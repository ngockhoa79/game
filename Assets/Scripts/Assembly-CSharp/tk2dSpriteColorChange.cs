using HutongGames.PlayMaker;

[ActionCategory("ICEE_Art")]
public class tk2dSpriteColorChange : FsmStateAction
{
	[RequiredField]
	public tk2dSprite target;

	[RequiredField]
	public FsmColor colorFrom;

	[RequiredField]
	public FsmColor colorTo;

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

	private void StartSet()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SetColor()
	{
	}
}
