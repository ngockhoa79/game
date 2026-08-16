using System;
using UnityEngine;

public class UICardShopFrame : IceUIBase
{
	public IceUIBtnGroup TabButton;

	public GameObject PanelPos;

	private int mSelectedIndex;

	private IceUIBase mSubPanel;

	[HideInInspector]
	public int SubPanelToOpen;

	public GameObject goNPC;

	public UIEventListener EventMain;

	public UIEventListener EventBack;

	public UIEventListener EventCharge;

	[HideInInspector]
	public bool IsInForeGround;

	public IceAnimatorTotalCommander Animate;

	private IceUIBase[] mSubUI;

	public IceUIBase SubPanel => null;

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

	public void OnGotoForeground()
	{
	}

	public void OnGotoBackground()
	{
	}

	public void OnChangeTab(int oldIndex, int newIndex)
	{
	}

	private void loadPanelByIndex(int index)
	{
	}
}
