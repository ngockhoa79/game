using System;
using UnityEngine;

public class UIMakyouBatterReport : IceUIBase
{
	[SerializeField]
	private UIEventListener closeBtn;

	[SerializeField]
	private UIMakyouBatReportListAnimator itemList;

	public Action E_OnClose;

	protected override void DoInit()
	{
	}

	private void onClose(GameObject obj)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void requestReports()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoDestroy()
	{
	}
}
