using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SendMsgsToSkillCtrller : FsmStateAction
{
	[RequiredField]
	public SkillCtrllerChildMsgType msgType;

	public FsmOwnerDefault gameObject;

	[RequiredField]
	public FsmFloat delay;

	[RequiredField]
	public FsmInt num;

	[RequiredField]
	public FsmFloat gap;

	private float startTimer;

	private float sendTimer;

	private bool started;

	private bool sendOver;

	private int current;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void StartSend()
	{
	}

	private void SendMsg()
	{
	}
}
