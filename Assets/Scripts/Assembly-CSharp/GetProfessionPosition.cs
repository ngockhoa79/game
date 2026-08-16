using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class GetProfessionPosition : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmVector3 position;

	public ProfessionPositionType positionType;

	public override void OnEnter()
	{
	}
}
