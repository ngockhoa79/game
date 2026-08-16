using HutongGames.PlayMaker;

[ActionCategory("CosUI")]
public class EditUITexture : FsmStateAction
{
	[RequiredField]
	public UITexture texture;

	public FsmInt depth;

	public FsmInt width;

	public FsmInt height;

	public FsmBool isActive;

	public override void OnEnter()
	{
	}
}
