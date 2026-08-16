using HutongGames.PlayMaker;

[ActionCategory("ConditionalJudgment")]
public class CheckPlayerPrefsFinished : FsmStateAction
{
	public int ProgressIndex;

	public FsmEvent jumpEvent;

	public override void OnEnter()
	{
	}
}
