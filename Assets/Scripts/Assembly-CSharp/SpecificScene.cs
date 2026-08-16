using HutongGames.PlayMaker;

[ActionCategory("ConditionalJudgment")]
public class SpecificScene : FsmStateAction
{
	public string SceneName;

	public FsmEvent missEvent;

	public override void OnEnter()
	{
	}
}
