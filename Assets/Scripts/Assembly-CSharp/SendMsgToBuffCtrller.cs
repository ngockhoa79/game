using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SendMsgToBuffCtrller : FsmStateAction
{
	[RequiredField]
	public BuffCtrllerMsgType msgType;

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
