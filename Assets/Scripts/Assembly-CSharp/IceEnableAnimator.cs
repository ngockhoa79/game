public class IceEnableAnimator : IceAnimator
{
	public float initEnable;

	public float targetEnable;

	public IceEnableAnimator()
		: base(0)
	{
	}

	protected override void Interpolate(params float[] args)
	{
	}

	public override void CopyTo(IceAnimator target)
	{
	}
}
