using HutongGames.PlayMaker;

[ActionCategory("ICEE")]
public class Vector3AddByHeroSide : FsmStateAction
{
	[RequiredField]
	public FsmGameObject hero;

	[RequiredField]
	public FsmVector3 vector3Variable;

	public FsmFloat addX;

	public FsmFloat addY;

	public FsmFloat addZ;

	public override void OnEnter()
	{
	}

	private void DoVector3AddXYZ()
	{
	}
}
