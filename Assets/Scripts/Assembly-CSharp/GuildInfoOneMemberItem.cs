using System;
using UnityEngine;

public class GuildInfoOneMemberItem : IceUIBase
{
	public UISprite FrameBg;

	public UISprite NameBg;

	public UITexture Head;

	public UISprite HeadFrame;

	public UISprite Post;

	public UISprite Vip;

	public UILabel Name;

	public UILabel Lv;

	public UILabel Contribution;

	public UILabel LastLogin;

	public UISprite BuildMark;

	private UIEventListener ItemButton;

	private GuildMemberInfo info;

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetData(GuildMemberInfo _info)
	{
	}

	public void ClearData()
	{
	}

	public void OnItemClick(GameObject go)
	{
	}
}
