using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class CharacterState : FsmStateAction
{
	[RequiredField]
	public FsmGameObject character;

	[RequiredField]
	public FsmString stateName;

	[RequiredField]
	public FsmFloat delay;

	private float timer;

	private bool setOver;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SetHeroState()
	{
	}
}
