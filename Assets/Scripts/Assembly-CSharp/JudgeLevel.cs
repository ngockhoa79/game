using HutongGames.PlayMaker;

[ActionCategory("ConditionalJudgment")]
public class JudgeLevel : FsmStateAction
{
	public enum Compare
	{
		OnlyEqual = 0,
		BiggerOrEqual = 1,
		Less = 2,
		LessOrEqual = 3
	}

	public Compare C;

	public int Level;

	public FsmEvent missEvent;

	public override void OnEnter()
	{
	}
}
