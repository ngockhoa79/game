using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class CosAttachToHero : FsmStateAction
{
	[RequiredField]
	public FsmGameObject attachHero;

	[RequiredField]
	public FsmGameObject attachObject;

	[RequiredField]
	public FsmVector3 offset;

	[RequiredField]
	[Tooltip("If totalTime <=0, last forever.")]
	public FsmFloat totalTime;

	[RequiredField]
	public FsmFloat delay;

	private float delayTimer;

	private float realTotalTime;

	private float totalTimer;

	private bool startAttach;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void StartAttach()
	{
	}
}
