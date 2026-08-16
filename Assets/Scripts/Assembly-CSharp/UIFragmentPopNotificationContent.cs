using System;
using Ice.ProjectCos.UI.DataModel;

public class UIFragmentPopNotificationContent : IceUIBase
{
	public UICmItemIcon portrait;

	public UILabel lbName;

	public UILabel lbGuildName;

	public UILabel lbLevel;

	public UILabel lbTime;

	public UILabel lbRobInfo;

	public UIEventListener btnSupport;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	public UISprite spVip;

	public Action<FragmentPopupNotificationContent> E_OnSupport;

	private FragmentPopupNotificationContent _data;

	public void SetData(FragmentPopupNotificationContent data)
	{
	}

	private string coloredFragmentName(SkillFragment sf)
	{
		return null;
	}

	private void ClearData()
	{
	}

	private void ShowContent(bool bNeedSupport)
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
