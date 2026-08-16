using System;
using UnityEngine;

public class UIOpActivityContent : IceUIBase
{
	[SerializeField]
	private IceAnimatorTotalCommander anim_select;

	[SerializeField]
	private IceAnimatorTotalCommander anim_noselect;

	[SerializeField]
	private IceAnimatorTotalCommander anim_stay_select;

	[SerializeField]
	private IceAnimatorTotalCommander anim_stay_noselect;

	[SerializeField]
	private UIEventListener collider;

	public Action<int> E_OnClick;

	private bool bAnimated;

	private int mOpActivityId;

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void SetData(int opActivityId)
	{
	}

	public void Select(bool bSelect, Action onCallback = null)
	{
	}

	private void _stop_all_animations()
	{
	}
}
