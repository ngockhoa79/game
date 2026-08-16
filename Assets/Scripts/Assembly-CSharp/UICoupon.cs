using System;
using UnityEngine;

public class UICoupon : IceUIBase
{
	[SerializeField]
	private UIInput input;

	[SerializeField]
	private UIEventListener uiConfirm;

	[SerializeField]
	private UIEventListener uiClose;

	[SerializeField]
	private UILabel lbDefault;

	private EventDelegate dele;

	public Action<string> E_OnConfirm;

	public Action E_OnClose;

	protected override void DoPrepare()
	{
	}

	private void OnChange()
	{
	}

	protected override void DoClearData()
	{
	}
}
