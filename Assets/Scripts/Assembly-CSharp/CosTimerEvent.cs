using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class CosTimerEvent : FsmStateAction
{
	[RequiredField]
	public FsmOwnerDefault targetObject;

	[RequiredField]
	public FsmFloat eventMinTime;

	[RequiredField]
	public FsmFloat eventMaxTime;

	[RequiredField]
	public FsmEvent eventType;

	[RequiredField]
	public FsmString eventName;

	private float timer;

	private float eventTime;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}
}
