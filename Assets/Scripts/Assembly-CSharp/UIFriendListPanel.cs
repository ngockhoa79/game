using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFriendListPanel : IceUIBase, IceUIReusableList<Friend>.IVisualizer
{
	public UILabel lbFirstFightTimes;

	public UILabel lbFriendDianValue;

	public UILabel lbFriendCount;

	public GameObject goHint;

	public GameObject goTitle;

	public UIFriendListAnimator FriendInfoList;

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

	public void SetData(GameObject widget, Friend data)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	private void RequestFriendInfos()
	{
	}

	public void OnFriendDetailInfo(Friend playerInfo)
	{
	}

	public void OnFriendQieCuo(Friend friend)
	{
	}

	public void SetList(List<Friend> friendlist)
	{
	}

	public void SetTitle()
	{
	}

	public void ResetPanel()
	{
	}

	private void storePanel()
	{
	}
}
