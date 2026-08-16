using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SetSkillName : FsmStateAction
{
	[RequiredField]
	public FsmString effectName;

	[RequiredField]
	public FsmFloat delay;

	private float timer;

	private bool setOver;

	private SkillCtrller skillCtrller;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SetName()
	{
	}
}
