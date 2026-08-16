using System;

public class UILoginServerContent : IceUIBase
{
	public UILabel lbAreaID;

	public UILabel lbAreaName;

	public UISprite spBaoMan;

	public UISprite spXinQu;

	public UIEventListener eventListener;

	public IceAnimatorTotalCommander animEnter;

	public IceAnimatorTotalCommander animExit;

	public Action<LoginServerInfo> E_OnClicked;

	private LoginServerInfo _data;

	public void SetData(LoginServerInfo data)
	{
	}

	private void SetServerStatus(int status)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}
