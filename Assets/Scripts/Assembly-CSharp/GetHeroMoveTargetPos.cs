using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class GetHeroMoveTargetPos : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public BattleHeroPosType type;

	[RequiredField]
	public FsmVector3 export;

	public override void OnEnter()
	{
	}
}
