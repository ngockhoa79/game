using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIGuilMemberRecordList : IceUIBase
{
	[SerializeField]
	private UIGuildMemberRecordListAnimator list;

	[SerializeField]
	private UIEventListener closeBtn;

	public Action E_OnClose;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void onClose(GameObject obj)
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void _refresh_batter_view_(S2CCrossGuildPlayerRankingAck ack)
	{
	}

	public void SetData(S2CCrossGuildPlayerRankingAck ack)
	{
	}
}
