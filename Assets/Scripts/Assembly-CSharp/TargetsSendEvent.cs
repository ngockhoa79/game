using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class TargetsSendEvent : FsmStateAction
{
	[RequiredField]
	public FsmString eventName;

	[RequiredField]
	public FsmFloat delay;

	[RequiredField]
	public BattleFsmType type;

	private float timer;

	private bool sendOver;

	private string childNamePrefix;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SendMsgToTargets()
	{
	}
}
