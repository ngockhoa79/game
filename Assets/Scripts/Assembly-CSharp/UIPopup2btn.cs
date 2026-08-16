using System;
using UnityEngine;

public class UIPopup2btn : IceUIBase
{
	[SerializeField]
	private UILabel LblTitle;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private UIEventListener CancelButton;

	public Action OnEnsure;

	public Action OnCancel;

	public void SetData(string title)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}

	private void OnCancelClicked(GameObject obj)
	{
	}
}
