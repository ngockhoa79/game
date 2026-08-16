using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class WaitCharacterStateEvent : FsmStateAction
{
	[RequiredField]
	public FsmGameObject characterObj;

	[RequiredField]
	public FsmString characterState;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}
}
