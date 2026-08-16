using System;
using System.Collections.Generic;

public class UILoginServerRoot : IceUIBase
{
	public UILoginServerList List;

	public UILoginServerPair RecentLogin;

	public UILoginServerGroup ServerGroupList;

	public UIEventListener btnClose;

	public UIEventListener[] ServerGroup;

	public Action E_OnClose;

	public Action<LoginServerInfo> E_OnServerSelected;

	private LoginServerInfo _curServerInfo;

	private int serverGroupLength;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	public void SetData(List<LoginServerInfo> data)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	public void SetServerData(int index)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void SelectItem(LoginServerInfo item)
	{
	}
}
