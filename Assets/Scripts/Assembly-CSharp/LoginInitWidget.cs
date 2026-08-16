using HutongGames.PlayMaker;

[ActionCategory("CosLogin")]
public class LoginInitWidget : FsmStateAction
{
	[RequiredField]
	public UIEventListener btnChangYouLogin;

	[RequiredField]
	public UIEventListener btnChangYouLogout;

	[RequiredField]
	public UIEventListener btnTestLogin;

	[RequiredField]
	public UILabel lbName;

	public override void OnEnter()
	{
	}

	public override void OnExit()
	{
	}

	private void OnTestLogin()
	{
	}

	private void OnChangYouLogin()
	{
	}
}
