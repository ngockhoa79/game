using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemFriendInfo : IceUIBase
{
	public GameObject displayerPlaceHolder;

	public UILabel lbLevel;

	public UILabel lbName;

	public UILabel lbTotalBattleValue;

	public UILabel lbGuildName;

	public UILabel lbLastLoginTime;

	public GameObject BgFriend;

	public GameObject BgMy;

	public UIEventListener eventItem;

	private GameObject portrait;

	private Friend mFriendData;

	private int mCurMinute;

	public Action<Friend> E_OnFriendInfoClicked;

	public UIAeCardDisplayer CardDisplay;

	public UIIndexIcon IndexIcon;

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

	public void SetData(Friend data)
	{
	}

	private string GetLastLoginTime()
	{
		return null;
	}

	public void SetIndex(int i)
	{
	}
}
