using System;
using UnityEngine;

public class UILoginServerInfo : IceUIBase
{
	[SerializeField]
	private UILabel lbAreaID;

	[SerializeField]
	private UILabel lbAreaName;

	[SerializeField]
	private UISprite spServerStatus;

	[SerializeField]
	private UIEventListener btn;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private IceAnimatorTotalCommander anim_out;

	public Action<LoginServerInfo> E_OnClick;

	private LoginServerInfo data;

	public LoginServerInfo Data => null;

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

	public void SetData(LoginServerInfo serverInfo)
	{
	}
}
