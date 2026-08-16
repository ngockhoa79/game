using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class GetCosPosition : FsmStateAction
{
	public FsmGameObject hero;

	[RequiredField]
	public CosBattlePosType type;

	[RequiredField]
	public FsmVector3 export;

	private BattleHeroInfo info;

	public override void OnEnter()
	{
	}
}
