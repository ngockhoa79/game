using UnityEngine;

public class IceTargetMovementAnimator : IceAnimator
{
	public Vector3 targetPosition;

	public float time;

	private Vector3 initPosition;

	public IceTargetMovementAnimator()
		: base(0)
	{
	}

	protected override void OnPlay()
	{
	}

	protected override void Interpolate(params float[] args)
	{
	}

	public override void CopyTo(IceAnimator target)
	{
	}
}
