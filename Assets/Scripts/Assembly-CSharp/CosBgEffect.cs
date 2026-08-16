using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class CosBgEffect : FsmStateAction
{
	[RequiredField]
	public BattleBgEffectType effectType;

	[RequiredField]
	public FsmFloat delay;

	private BattleCameraCtrller camCtrller;

	private float timer;

	private bool setOver;

	public override void OnEnter()
	{
	}

	public override void OnUpdate()
	{
	}

	private void SetBgEffect()
	{
	}
}
