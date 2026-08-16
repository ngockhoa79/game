public class IceWidgetDepthAnimator : IceAnimator
{
	public float InitDepth;

	public float TargetDepth;

	public float StaticDepth;

	public IceWidgetDepthAnimator()
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
