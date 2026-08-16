using System.Collections.Generic;

public class IceNGUIAlphaAnimator : IceAnimator
{
	public float InitAlpha;

	public float TargetAlpha;

	public float StaticAlpha;

	public bool UseInitAlpha;

	private Dictionary<int, float> _widgetsInitColor;

	private bool bStart;

	public IceNGUIAlphaAnimator()
		: base(0)
	{
	}

	public void Animate(float initialAlpha, float targetAlpha)
	{
	}

	protected override void OnPlay()
	{
	}

	protected override void OnStartPlay()
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
