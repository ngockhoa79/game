using HutongGames.PlayMaker;

[ActionCategory("ConditionalJudgment")]
public class JudgeSpecifiedChapter : FsmStateAction
{
	private const int Tutorial9 = 9;

	public int Chapter;

	public FsmEvent missEvent;

	public override void OnEnter()
	{
	}
}
