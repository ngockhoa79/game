using System;
using HutongGames.PlayMaker;
using Ice.SampleGame.LibClient.Protocol;

[ActionCategory("ConditionalJudgment")]
public class CheckSpecifiedOperationFinished : FsmStateAction
{
	public string AckString;

	private int identifier;

	private Type ackType;

	public FsmEvent Fallback;

	public bool DoubleCheckResultCode;

	public string CodeName;

	public string CodeValue;

	private LibClientProtoProvider p;

	public override void OnEnter()
	{
	}

	public override void OnExit()
	{
	}

	private void onSent(int id)
	{
	}

	public int GetAckID()
	{
		return 0;
	}

	public Type GetAckType()
	{
		return null;
	}

	public string GetCodeValue()
	{
		return null;
	}

	public string GetCodeName()
	{
		return null;
	}

	public void HandleFallback()
	{
	}
}
