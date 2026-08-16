using UnityEngine;

public class IceEulerRotationAnimator : IceAnimator
{
	public Vector3 InitialRotation_Angle;

	public Vector3 TargetRotation_Angle;

	public Vector3 StaticRotation_Angle;

	public IceEulerRotationAnimator()
		: base(0)
	{
	}

	public void Animate(Vector3 initialRotation_Angle, Vector3 targetRotation_Angle)
	{
	}

	public void RotateTo(Vector3 TargetRotation_Angleation)
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
