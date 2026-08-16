using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class GetWaveHitTime : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmFloat export;

	public override void OnEnter()
	{
	}
}
