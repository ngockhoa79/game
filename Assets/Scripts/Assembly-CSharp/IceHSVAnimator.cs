public class IceHSVAnimator : IceAnimator
{
	public float initH;

	public float targetH;

	public float initS;

	public float targetS;

	public float initV;

	public float targetV;

	public float initA;

	public float targetA;

	public IceHSVAnimator()
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
