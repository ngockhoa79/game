using HutongGames.PlayMaker;

[ActionCategory("ConditionalJudgment")]
public class JudgeIntent : FsmStateAction
{
	public string[] IntentName;

	public FsmEvent missEvent;

	public override void OnEnter()
	{
	}
}
