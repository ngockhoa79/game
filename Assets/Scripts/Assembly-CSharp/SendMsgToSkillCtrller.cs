using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SendMsgToSkillCtrller : FsmStateAction
{
	[RequiredField]
	public SkillCtrllerChildMsgType msgType;

	public FsmOwnerDefault gameObject;

	[RequiredField]
	public FsmFloat delay;

	private float timer;

	private bool sendOver;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SendMsg()
	{
	}
}
