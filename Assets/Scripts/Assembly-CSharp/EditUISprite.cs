using HutongGames.PlayMaker;

[ActionCategory("CosUI")]
public class EditUISprite : FsmStateAction
{
	[RequiredField]
	public UISprite target;

	public FsmString spriteName;

	public FsmInt depth;

	public FsmBool isPixelPerfect;

	public FsmInt width;

	public FsmInt height;

	public FsmColor color;

	public FsmBool isActive;

	public override void OnEnter()
	{
	}
}
