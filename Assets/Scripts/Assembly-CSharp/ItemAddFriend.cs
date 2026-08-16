using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemAddFriend : IceUIBase
{
	public UILabel lbLevel;

	public UILabel lbName;

	public UILabel lbTotalBattleValue;

	public UISprite spDark;

	public UISprite spHighLight;

	public UILabel lbGuildName;

	public UIEventListener eventInvite;

	public GameObject btnInvite;

	public GameObject spriteSent;

	public UILabel lbLastTime;

	public UIAeCardDisplayer CardDisplay;

	private Friend mFriendToAdd;

	public Action<ItemAddFriend, Friend> OnAddFriend;

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

	public void OnInviteClick()
	{
	}
}
