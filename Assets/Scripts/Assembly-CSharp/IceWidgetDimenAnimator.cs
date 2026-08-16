using UnityEngine;

public class IceWidgetDimenAnimator : IceAnimator
{
	public Vector2 InitDimension;

	public Vector2 TargetDimension;

	public Vector2 StaticDimension;

	public IceWidgetDimenAnimator()
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
}
