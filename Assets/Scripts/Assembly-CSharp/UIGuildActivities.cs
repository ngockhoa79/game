using System.Collections.Generic;
using UnityEngine;

public class UIGuildActivities : IceUIBase
{
	public UIEventListener closeButton;

	public UIGuildActivityList MessageList;

	public UITable Table;

	public int ActivityComparer(GuildActivityData itemA, GuildActivityData itemB)
	{
		return 0;
	}

	public void SetDetail(List<GuildActivityData> messages)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void onClose(GameObject btn)
	{
	}
}
