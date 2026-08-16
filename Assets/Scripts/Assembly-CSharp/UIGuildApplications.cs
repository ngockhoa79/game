using System.Collections.Generic;
using UnityEngine;

public class UIGuildApplications : IceUIBase
{
	public UIEventListener closeButton;

	public UIGuildApplicationList ApplicationList;

	public UITable Table;

	public int ApplicationComparer(GuildApplicationData itemA, GuildApplicationData itemB)
	{
		return 0;
	}

	public void SetDetail(List<GuildApplicationData> applications)
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
