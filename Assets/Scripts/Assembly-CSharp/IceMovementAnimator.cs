using UnityEngine;

public class IceMovementAnimator : IceAnimator
{
	public Vector3 InitialPosition;

	public Vector3 TargetPosition;

	public Vector3 StaticPosition;

	public bool UseWorldSpacePosition;

	public bool IncludeZ;

	public IceMovementAnimator()
		: base(0)
	{
	}

	public void Animate(Vector3 initialPos, Vector3 targetPos)
	{
	}

	public void MoveTo(Vector3 TargetPosition)
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
