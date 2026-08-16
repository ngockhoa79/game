using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFriendAddPanel : IceUIBase, IceUIReusableList<Friend>.IVisualizer
{
	public UILabel lbMyID;

	public UIInput inputFriendId;

	public GameObject goHint;

	public UIFriendListAnimator FriendAddList;

	public UIButton bnInviteAll;

	public UIButton bnRefresh;

	public UIButton bnSearch;

	public UIEventListener evInviteAll;

	public UIEventListener evRefresh;

	public UIEventListener evSearch;

	private bool mIsEnable;

	public UIEventListener inputBtnWebGL;

	private List<Friend> mCurListToInvite;

	public UIPanel ClipPanel;

	private Vector2 mClipOffset;

	private Vector4 mClipRegion;

	private Vector3 mClipPos;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoDispose()
	{
	}

	public GameObject CreateWidget(Transform widgetsHolder)
	{
		return null;
	}

	public GameObject CreateSeparator(Transform widgetsHolder)
	{
		return null;
	}

	public void SetData(GameObject widget, Friend f)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void ButtonDisable()
	{
	}

	public void ButtonEnableIfNeed()
	{
	}

	public void SetList(List<Friend> friendAddList)
	{
	}

	public void SetTitle()
	{
	}

	private void AddFriend(ItemAddFriend ui, Friend friend)
	{
	}

	private void SearchFriend(string text)
	{
	}

	public void RequestPromoteList()
	{
	}

	public void ResetPanel()
	{
	}

	private void storePanel()
	{
	}

	public void OnSearchClick()
	{
	}

	public void OnRefreshClick()
	{
	}

	public void OnInviteAllClick()
	{
	}
}
