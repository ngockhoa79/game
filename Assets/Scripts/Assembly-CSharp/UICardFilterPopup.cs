using System;
using UnityEngine;

public class UICardFilterPopup : IceUIBase
{
	[SerializeField]
	private UIEventListener[] filterButton;

	[SerializeField]
	private UIEventListener closeButton;

	public Action OnEnsure;

	public Action OnCancel;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnSelectClicked(GameObject obj)
	{
	}

	protected override void DoShowOnscreen()
	{
	}
}
