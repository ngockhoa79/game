using UnityEngine;

public class EulerRotationAnimator : AbstractAnimator
{
	public Vector3 InitialRotation_Angle;

	public Vector3 TargetRotation_Angle;

	public void Animate(Vector3 initialRotation_Angle, Vector3 targetRotation_Angle)
	{
	}

	public void RotateTo(Vector3 TargetRotation_Angleation)
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
