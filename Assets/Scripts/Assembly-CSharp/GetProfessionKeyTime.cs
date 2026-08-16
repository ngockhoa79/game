using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
[Tooltip("Get animation key time by hero's profession index.")]
public class GetProfessionKeyTime : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmFloat keyTime;

	public ProfessionKeyTimeType keyName;

	public override void OnEnter()
	{
	}
}
