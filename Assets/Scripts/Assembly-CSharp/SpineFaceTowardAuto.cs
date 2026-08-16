using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SpineFaceTowardAuto : FsmStateAction
{
	[RequiredField]
	public FsmGameObject characterObj;

	[RequiredField]
	public FsmBool reverse;

	public override void OnEnter()
	{
	}
}
