using System;
using UnityEngine;

public class FloatingBoardNew : IceUIBase
{
	public FloatingBoardCustom uiCustom;

	public FloatingBoardDefault uiDefault;

	public IceAnimatorTotalCommander anim;

	public UIPanel panel;

	public static int DefaultDepth;

	public static int CustomDepth;

	public void ShowMessage(string tag, string message, Action onConfirm = null, Action onClosed = null, bool bContainCollider = false)
	{
	}

	public void ShowMessage(string message, Action onConfirm = null, Action onClosed = null)
	{
	}

	public void ShowOkCancelMessage(string tag, string message, Action onOk = null, Action onCancel = null, Action onClosed = null, bool bContainCollider = false)
	{
	}

	public void ShowOkCancelMessage(string message, Action onOk = null, Action onCancel = null, Action onClosed = null, bool bContainCollider = false)
	{
	}

	public void ShowCustomMessage(GameObject customPanel, Action onEntered, Action onClose, int height, int width, bool bContainCollider)
	{
	}

	private void ShowFrame()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void activateFunnyRenderers(bool active)
	{
	}
}
