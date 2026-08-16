using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class PlayImmuneEffect : FsmStateAction
{
	[RequiredField]
	public FsmGameObject mainHero;

	public FsmGameObject attachHero;

	[RequiredField]
	public FsmVector3 offset;

	[RequiredField]
	public FsmFloat delay;

	public FsmGameObject export;

	public FsmVector3 exportOffset;

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
