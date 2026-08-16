using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class PlayEffectSide : FsmStateAction
{
	[RequiredField]
	public FsmGameObject mainHero;

	public FsmGameObject attachHero;

	[RequiredField]
	public FsmString leftEffect;

	[RequiredField]
	public FsmString rightEffect;

	[RequiredField]
	public FsmVector3 offset;

	[RequiredField]
	public FsmFloat delay;

	public FsmGameObject export;

	private bool playOver;

	private float timer;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void Play()
	{
	}
}
