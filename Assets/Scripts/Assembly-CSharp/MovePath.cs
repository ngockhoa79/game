using HutongGames.PlayMaker;

[ActionCategory("ICEE_Art")]
public class MovePath : FsmStateAction
{
	public enum MoveMode
	{
		Loop = 0,
		FromCurrentPosition = 1,
		FromFirstPosition = 2
	}

	public MoveMode moveMode;

	public FsmVector3[] path;

	public FsmFloat startSpeed;

	public FsmFloat endSpeed;

	public FsmAnimationCurve sppedAnimation;

	public FsmFloat timeLast;

	public FsmEvent finishEvent;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}
}
