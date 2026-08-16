using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class SetHeroRGBA : FsmStateAction
{
	[RequiredField]
	public FsmGameObject attachHero;

	[HasFloatSlider(0f, 1f)]
	public FsmFloat red;

	[HasFloatSlider(0f, 1f)]
	public FsmFloat green;

	[HasFloatSlider(0f, 1f)]
	public FsmFloat blue;

	[HasFloatSlider(0f, 1f)]
	public FsmFloat alpha;

	[RequiredField]
	public FsmFloat delay;

	[Tooltip("If not set every frame, ignore last.")]
	public bool everyFrame;

	[RequiredField]
	public FsmFloat last;

	private float delayTimer;

	private float lastTimer;

	private bool startSet;

	public override void Reset()
	{
	}

	public override void OnEnter()
	{
	}

	private void StartSet()
	{
	}

	public override void OnUpdate()
	{
	}

	private void DoSetColorRGBA()
	{
	}
}
