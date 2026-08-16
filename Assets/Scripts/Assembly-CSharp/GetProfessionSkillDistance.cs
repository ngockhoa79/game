using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class GetProfessionSkillDistance : FsmStateAction
{
	[RequiredField]
	public FsmGameObject character;

	[RequiredField]
	public FsmFloat skillDistance;

	public ProfessionSkillDistanceType skillType;

	public override void OnEnter()
	{
	}
}
