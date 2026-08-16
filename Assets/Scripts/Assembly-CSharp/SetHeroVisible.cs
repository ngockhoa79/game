using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SetHeroVisible : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	public FsmBool visible;

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

	private void SetVisible()
	{
	}
}
