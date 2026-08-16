using UnityEngine;

public class IceAnimAnimator : IceAnimator
{
	private enum AnimState
	{
		Delay = 0,
		Playing = 1,
		Interval = 2,
		Stop = 3
	}

	public string animationName;

	public Animation targetAnimation;

	public float animation_delayTime;

	public float animation_intervalTime;

	private float animInterop;

	private AnimState animState;

	public IceAnimAnimator()
		: base(0)
	{
	}

	protected override void Interpolate(params float[] args)
	{
	}

	public override void ResetToStaticState()
	{
	}

	public override void CopyTo(IceAnimator target)
	{
	}

	public override void OnUpdate()
	{
	}

	protected override void OnStop()
	{
	}

	protected override void OnPlay()
	{
	}
}
