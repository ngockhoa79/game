using System;
using UnityEngine;

public class UIGearFilterPopup : IceUIBase
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

	protected override void DoShowOnscreen()
	{
	}

	private void OnSelectClicked(GameObject obj)
	{
	}
}
