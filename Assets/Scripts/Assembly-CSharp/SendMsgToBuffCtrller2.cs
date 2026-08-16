using System;
using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SendMsgToBuffCtrller2 : FsmStateAction
{
	private static int Count;

	private static DateTime last_now;

	[RequiredField]
	public BuffCtrllerMsgType msgType;

	public FsmOwnerDefault gameObject;

	[RequiredField]
	public FsmFloat delay1;

	[RequiredField]
	public FsmFloat delay2;

	private float timer;

	private bool sendOver;

	private int currentCount;

	private float Delay => 0f;

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
