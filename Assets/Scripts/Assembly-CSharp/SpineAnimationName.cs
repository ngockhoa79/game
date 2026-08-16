using HutongGames.PlayMaker;
using Spine;
using Spine36;
using Spine36.Unity;
using SpineWWW;
using SpineWWW.Unity;

[Tooltip("Play Spine Animation.")]
[ActionCategory("ICEE")]
public class SpineAnimationName : FsmStateAction
{
	[Tooltip("Animation name.")]
	[RequiredField]
	public FsmString animationName;

	[Tooltip("Is a loop animation")]
	public FsmBool loop;

	[Tooltip("On anmation completed.")]
	public FsmEvent onComplete;

	private SkeletonAnimation skeletonAnimation;

	private SpineWWW.Unity.SkeletonAnimation skeletonAnimationNew;

	private Spine36.Unity.SkeletonAnimation skeletonAnimation36;

	private bool endEventHandled;

	public override void OnEnter()
	{
	}

	public override void OnExit()
	{
	}

	private void animationEnd(Spine.AnimationState state, int trackIndex, int loopCount)
	{
	}

	private void animationEndNew(SpineWWW.TrackEntry obj)
	{
	}

	private void animationEnd36(Spine36.TrackEntry obj)
	{
	}

	private void handleAnimationEndEvent()
	{
	}
}
