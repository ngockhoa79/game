using HutongGames.PlayMaker;

[ActionCategory("ICEE_Art")]
public class SetTk2dSpriteColor : FsmStateAction
{
	[RequiredField]
	public tk2dSprite target;

	[RequiredField]
	public FsmColor color;

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

	private void SetColor()
	{
	}
}
