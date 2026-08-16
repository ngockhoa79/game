using System;
using UnityEngine;

public class FloatingBoardCustom : IceUIBase
{
	public UIEventListener btnClose;

	public UIFloatingBoardFrame frame;

	public Action E_OnClose;

	public Action E_OnEnter;

	public const int DEFAULT_HEIGHT = 404;

	public const int DEFAULT_WIDTH = 656;

	private bool bOpen;

	private GameObject subPanel;

	public void SetCustomData(GameObject subPanelSource, Action onEntered = null, Action onClose = null, int panelHeight = 404, int panelWidth = 656, bool bContainCollider = false)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoClearData()
	{
	}
}
