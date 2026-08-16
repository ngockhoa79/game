using HutongGames.PlayMaker;

[ActionCategory("CosUI")]
public class BindEventListener : FsmStateAction
{
	[RequiredField]
	public UIEventListener uiEventListener;

	public PlayMakerFSM onClickFsm;

	public PlayMakerFSM onPressDownFsm;

	public PlayMakerFSM onPressUpFsm;

	public override void OnEnter()
	{
	}

	public override void OnExit()
	{
	}
}
