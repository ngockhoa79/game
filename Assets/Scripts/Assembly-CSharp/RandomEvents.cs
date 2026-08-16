using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
[Tooltip("Random a number between [0,Max], if number between [0, KeyValue), call event1, else call event2.")]
public class RandomEvents : FsmStateAction
{
	[RequiredField]
	public FsmOwnerDefault targetObject;

	[RequiredField]
	public FsmInt max;

	[RequiredField]
	public FsmInt keyValue;

	[RequiredField]
	public FsmString event1;

	[RequiredField]
	public FsmString event2;

	public override void Reset()
	{
	}

	public override void OnEnter()
	{
	}
}
