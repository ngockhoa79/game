using HutongGames.PlayMaker;

[ActionCategory("ICEE_Art")]
public class SendFsmEvent : FsmStateAction
{
	public PlayMakerFSM fsm;

	[RequiredField]
	public FsmString fsmEvent;

	public override void OnEnter()
	{
	}
}
