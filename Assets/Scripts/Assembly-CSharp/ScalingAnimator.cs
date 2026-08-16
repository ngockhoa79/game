using UnityEngine;

public class ScalingAnimator : AbstractAnimator
{
	public Vector3 InitialScale;

	public Vector3 TargetScale;

	public void Animate(Vector3 initialScale, Vector3 targetScale)
	{
	}

	public void ScaleTo(Vector3 TargetScale)
	{
	}

	protected override void Interpolate(float arg)
	{
	}

	public override void GrabInitialState()
	{
	}

	public override void GrabTargetState()
	{
	}

	public override void CopyTo(AbstractAnimator target)
	{
	}
}
