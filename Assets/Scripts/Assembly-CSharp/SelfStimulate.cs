using HutongGames.PlayMaker;

[ActionCategory("SquanderGuidance")]
public class SelfStimulate : FsmStateAction
{
	private Init init;

	public int TransitionIndex;

	private static bool pass;

	public override void OnEnter()
	{
	}

	public static void Lull(bool working)
	{
	}
}
