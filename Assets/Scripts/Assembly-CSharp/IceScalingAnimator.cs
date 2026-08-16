using UnityEngine;

public class IceScalingAnimator : IceAnimator
{
	public Vector3 InitialScale;

	public Vector3 TargetScale;

	public Vector3 StaticScale;

	public IceScalingAnimator()
		: base(0)
	{
	}

	public void Animate(Vector3 initialScale, Vector3 targetScale)
	{
	}

	public void ScaleTo(Vector3 TargetScale)
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
}
