using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class PlayEffectProfession : FsmStateAction
{
	[RequiredField]
	public FsmGameObject effectHero;

	[RequiredField]
	public FsmGameObject attachHero;

	[RequiredField]
	public FsmVector3 offset;

	[RequiredField]
	public FsmFloat delay;

	public FsmString heavySwordMale;

	public FsmString heavySwordFemale;

	public FsmString lightSwordMale;

	public FsmString lightSwordFemale;

	public FsmString fighterMale;

	public FsmString fighterFemale;

	public FsmString mageMale;

	public FsmString mageFemale;

	public FsmGameObject export;

	private bool playOver;

	private float timer;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void PlayEffect()
	{
	}
}
