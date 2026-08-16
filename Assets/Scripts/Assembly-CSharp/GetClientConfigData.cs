using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class GetClientConfigData : FsmStateAction
{
	[RequiredField]
	public FsmString name;

	[RequiredField]
	public FsmFloat export;

	public override void OnEnter()
	{
	}
}
