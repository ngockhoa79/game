using HutongGames.PlayMaker;

[ActionCategory("ICEE_Art")]
public class tk2dPlaySpriteAnimation : FsmStateAction
{
	[RequiredField]
	public FsmGameObject tk2dGameObject;

	public FsmString clipName;

	public FsmEvent finishEvent;

	public tk2dSpriteAnimationClip.WrapMode mode;

	public FsmFloat loopTime;

	public FsmFloat delay;

	private tk2dSpriteAnimator animator;

	private float timer;

	private bool playOver;

	private bool looping;

	private float loopTimer;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void Play()
	{
	}

	private void FinishFsm()
	{
	}
}
