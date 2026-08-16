using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class PlaySounds : FsmStateAction
{
	[RequiredField]
	public FsmString sound;

	[RequiredField]
	public FsmFloat delay;

	[RequiredField]
	public FsmInt num;

	[RequiredField]
	public FsmFloat gap;

	private float startTimer;

	private float playTimer;

	private bool started;

	private bool playOver;

	private int current;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void StartPlay()
	{
	}

	private void PlaySound()
	{
	}
}
