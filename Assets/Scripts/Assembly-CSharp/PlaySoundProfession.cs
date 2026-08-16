using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class PlaySoundProfession : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmFloat delay;

	public FsmString heavySwordMale;

	public FsmString heavySwordFeMale;

	public FsmString lightSwordMale;

	public FsmString lightSwordFemale;

	public FsmString fighterMale;

	public FsmString fighterFemale;

	public FsmString mageMale;

	public FsmString mageFemale;

	private bool playOver;

	private float timer;

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
