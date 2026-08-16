using HutongGames.PlayMaker;

[ActionCategory("ConditionalJudgment")]
public class CheckSpecifiedProgressFinished : FsmStateAction
{
	public int ProgressIndex;

	public FsmEvent missEvent;

	public override void OnEnter()
	{
	}
}
