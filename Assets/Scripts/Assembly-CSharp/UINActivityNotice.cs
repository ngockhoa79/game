using System;
using System.Collections.Generic;
using UnityEngine;

public class UINActivityNotice : IceUIBase
{
	[SerializeField]
	private IceAnimatorTotalCommander animation_in;

	[SerializeField]
	private IceAnimatorTotalCommander animation_out;

	[SerializeField]
	private UIGrid listRoot;

	[SerializeField]
	private UILabel lbTitle;

	[SerializeField]
	private UILabel lbContent;

	[SerializeField]
	private UIEventListener btnClose;

	[SerializeField]
	private UIProgressBar progressbar;

	public Action E_OnClose;

	private List<ActivityNoticeContent> _data;

	private List<UINActivityNoticeContent> allList;

	private UINActivityNoticeContent CurSelected;

	private bool isFirst;

	public void SetData(List<ActivityNoticeContent> data)
	{
	}

	private void Update()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void _add_content_(int index, ActivityNoticeContent content)
	{
	}

	private void _select_(ActivityNoticeContent content)
	{
	}

	private void _select_view_(UINActivityNoticeContent view)
	{
	}
}
