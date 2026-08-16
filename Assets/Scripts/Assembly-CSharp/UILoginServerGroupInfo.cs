using System;
using System.Collections.Generic;
using UnityEngine;

public class UILoginServerGroupInfo : IceUIBase
{
	[SerializeField]
	private UILabel lbServerGroup;

	[SerializeField]
	private UIEventListener btn;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	private LoginServerGroup data;

	private List<LoginServerInfo> allSelectServerInfoList;

	public LoginServerGroup Data => null;

	public List<LoginServerInfo> allServerInfoList => null;

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	public void SetData(string Group)
	{
	}

	public void ServerGroupClick(int index)
	{
	}
}
