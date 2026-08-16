using System;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGuildMemberInfo : IceUIBase
{
	public UIAeCardDisplayer CardDisplay;

	public GameObject LeaderIcon;

	public GameObject ViceLeaderIcon;

	public UILabel PlayerName;

	public UILabel PlayerLevel;

	public UILabel FightPower;

	public UILabel GuildName;

	public GameObject GuildGroup;

	public GameObject NoGuildGroup;

	public UILabel ArenaRank;

	public UILabel Signature;

	public UIEventListener closeButton;

	public UIEventListener ButtonAddFriend;

	public UIEventListener ButtonDeleteFriend;

	public UIEventListener ButtonViewArray;

	public UIEventListener ButtonLeaveMessage;

	public UIEventListener ButtonVS;

	public UIEventListener ButtonPromote;

	public UIEventListener ButtonFire;

	public UIEventListener ButtonTransferLeadership;

	public UIEventListener ButtonKickout;

	public Action E_AfterAddFriend;

	public Action E_AfterDeleteFriend;

	public Action E_AfterViewArray;

	public Action E_AfterLeaveMessage;

	public Action E_AfterVS;

	public Action E_AfterPromote;

	public Action E_AfterDemote;

	public Action E_AfterTransferLeadership;

	public Action E_AfterKickout;

	protected Friend playerInfo;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void ClearData()
	{
	}

	public void SetData(Friend data, GuildMemberInfoProto.TypeEnum guildPost, int arenaRank)
	{
	}

	public void ClosePanel()
	{
	}

	public void OnCloseClick(GameObject go)
	{
	}

	public void OnButtonAddFriendClick(GameObject go)
	{
	}

	public void OnButtonDeleteFriendClick(GameObject go)
	{
	}

	public void OnButtonViewArrayClick(GameObject go)
	{
	}

	public void OnButtonLeaveMessageClick(GameObject go)
	{
	}

	private void handleMsg(string str)
	{
	}

	public void OnButtonVSClick(GameObject go)
	{
	}

	private void gotoChangeFormation()
	{
	}

	private void requestQieCuo(Friend f)
	{
	}

	private void showBattleLog()
	{
	}

	public void OnButtonPromoteClick(GameObject go)
	{
	}

	public void RequestPromote()
	{
	}

	public void OnButtonDemoteClick(GameObject go)
	{
	}

	public void RequestDemote()
	{
	}

	public void OnButtonTransferLeadershipClick(GameObject go)
	{
	}

	public void RequestTransferLeadership()
	{
	}

	public void OnButtonKickoutClick(GameObject go)
	{
	}

	public void RequestKickout()
	{
	}

	public void RefreshGuildRoot()
	{
	}
}
