using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFriendNotifyPanel : IceUIBase, IceUIReusableList<FriendNotification>.IVisualizer
{
	public UIFriendNotifyAnimator NotityList;

	public GameObject goHint;

	public UIEventListener EventBattleList;

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

	public void SetData(GameObject widget, FriendNotification data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void RequestNoticeList()
	{
	}

	public void SetList()
	{
	}

	public void OnChooseAcceptOrRejectFriend(FriendNotification friNoty, ItemFriendNotify uiItem, bool isAccept)
	{
	}

	public void OnLeaveMsg(FriendNotification friNoty)
	{
	}

	public void gotoBattleList()
	{
	}

	public void ResetPanel()
	{
	}

	private void storePanel()
	{
	}
}
