using UnityEngine;

public class MovementAnimator : AbstractAnimator
{
	public Vector3 InitialPosition;

	public Vector3 TargetPosition;

	public bool UseWorldSpacePosition;

	public bool IncludeZ;

	public void Animate(Vector3 initialPos, Vector3 targetPos)
	{
	}

	public void MoveTo(Vector3 TargetPosition)
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
