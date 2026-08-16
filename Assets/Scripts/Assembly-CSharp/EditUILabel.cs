using HutongGames.PlayMaker;

[ActionCategory("CosUI")]
public class EditUILabel : FsmStateAction
{
	[RequiredField]
	public UILabel target;

	public FsmString text;

	public FsmInt depth;

	public FsmColor color;

	public FsmBool isActive;

	public override void OnEnter()
	{
	}
}
