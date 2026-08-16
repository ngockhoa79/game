using HutongGames.PlayMaker;

[Tooltip("Do when spine animation ends")]
[ActionCategory("ICEE")]
public class AddAnimationEndListener : FsmStateAction
{
	[RequiredField]
	public FsmGameObject characterObj;

	public FsmEvent endEvent;

	[RequiredField]
	public FsmFloat delay;

	private float timer;

	private float totalTimer;

	private bool sendOver;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SendEvent()
	{
	}

	public void OnAnimationEndEvent()
	{
	}
}
