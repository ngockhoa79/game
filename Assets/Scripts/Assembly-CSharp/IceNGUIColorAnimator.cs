using UnityEngine;

public class IceNGUIColorAnimator : IceAnimator
{
	public Color InitialColor;

	public Color TargetColor;

	public Color StaticColor;

	public IceNGUIColorAnimator()
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
