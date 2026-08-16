using System;
using UnityEngine;

public class UIGuildRename : IceUIBase
{
	public UIEventListener ButtonOK;

	public UIEventListener ButtonCancel;

	public UIInput TextInput;

	public Action<string> E_NameChanged;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void ClosePanel()
	{
	}

	public void OnButtonOKClick(GameObject go)
	{
	}

	public void RequestRename()
	{
	}

	public void OnButtonCancelClick(GameObject go)
	{
	}
}
