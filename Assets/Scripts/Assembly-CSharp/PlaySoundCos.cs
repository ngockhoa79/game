using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class PlaySoundCos : FsmStateAction
{
	[RequiredField]
	public FsmString sound;

	[RequiredField]
	public FsmFloat delay;

	public FsmBool isStream;

	public FsmFloat playTime;

	private float timer;

	private bool setOver;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void PlaySound()
	{
	}
}
