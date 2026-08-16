using System;

public class UIFragmentPopupContent : IceUIBase
{
	public UICmItemIcon portrait;

	public UILabel lbName;

	public UILabel lbGuildName;

	public UILabel lbLevel;

	public UILabel lbTime;

	public UISprite spWin;

	public UISprite spLose;

	public UILabel lbRobInfo;

	public UIEventListener btnFanji;

	public UIEventListener btnHelp;

	public UIEventListener btnReplay;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	public UISprite spVip;

	public Action<FragmentPopupContent> E_OnCounter;

	public Action<FragmentPopupContent> E_OnHelp;

	public Action<FragmentPopupContent> E_OnReplay;

	private FragmentPopupContent _data;

	public void SetData(FragmentPopupContent data)
	{
	}

	private void ClearData()
	{
	}

	private void ShowContent(bool bWin, bool bShowHelp)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}
}
