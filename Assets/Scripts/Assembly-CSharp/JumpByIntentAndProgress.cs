using HutongGames.PlayMaker;

[ActionCategory("ConditionalJudgment")]
public class JumpByIntentAndProgress : FsmStateAction
{
	public string fromIntent;

	public int progressIndex;

	public FsmEvent progressFinish;

	public FsmEvent progressNotFinish;

	public override void OnEnter()
	{
	}
}
