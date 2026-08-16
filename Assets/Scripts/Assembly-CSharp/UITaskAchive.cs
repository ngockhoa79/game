using System;

public class UITaskAchive : IceUIBase
{
	public IceUIBtnGroup TabButton;

	private int mSelectedIndex;

	public IceUIBase[] SubUIs;

	public UIEventListener eventOutMain;

	public UIEventListener eventOutBack;

	private bool _check_open_dailyTask()
	{
		return false;
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
		Ice.ProjectCos.UI.Util.DelegateX.InvokeSafely(onEnterScreen);
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
		Ice.ProjectCos.UI.Util.DelegateX.InvokeSafely(onExitScreen);
	}

	protected override void DoDispose()
	{
	}

	public void OnChangeTab(int oldIndex, int newIndex)
	{
	}
}
