using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemFriendNotify : IceUIBase
{
	public delegate void FriendDeceideDelegate(FriendNotification friNoty, bool isAccept);

	public UILabel lbTime;

	public UILabel lbMessage;

	public UILabel lbLevel;

	public UILabel lbName;

	public UILabel lbGuildName;

	public GameObject BgMy;

	public GameObject BgOther;

	public GameObject YesNoButtons;

	public GameObject alreadyAddedRoot;

	public GameObject alreadyRefusedRoot;

	public GameObject leaveMessageRoot;

	public GameObject LevelRoot;

	public UIEventListener acceptEvent;

	public UIEventListener denyEvent;

	public UIEventListener leaveMessageEvent;

	public Action<FriendNotification, ItemFriendNotify, bool> E_OnAcceptOrRejectFriend;

	public Action<FriendNotification> E_OnLeaveMsg;

	public UIAeCardDisplayer CardDisplay;

	private FriendNotification mFriNoty;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public void Clear()
	{
	}

	public void SetData(FriendNotification data)
	{
	}

	private void refreshByState()
	{
	}

	public void AcceptFriend(GameObject go)
	{
	}

	public void RejectFriend(GameObject go)
	{
	}

	private string GetLastLoginTime(DateTime lastTime)
	{
		return null;
	}
}
