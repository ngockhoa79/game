using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class GuildMemberListBatter : IceUIBase
{
	[SerializeField]
	private GuildMemberListAnimator list;

	[SerializeField]
	private UILabel guildNameLabel;

	[SerializeField]
	private UILabel roundLabel;

	[SerializeField]
	private UILabel countLabel;

	[SerializeField]
	private UILabel rankLabel;

	[SerializeField]
	private UISprite guildHeadIcon;

	[SerializeField]
	private UIEventListener closeBtn;

	[SerializeField]
	private GameObject selfProp;

	public Action E_OnClose;

	private bool isInBatter;

	private void refrush(CrossGuildBattleResultProto proto)
	{
	}

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

	public void SetData(S2CCrossGuildBattleResultAck ack)
	{
	}
}
