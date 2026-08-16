using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFriendAddPopup : MonoBehaviour
{
	public UICmItemIcon head;

	public UILabel nameLabel;

	public UILabel lvLabel;

	public UILabel fightvalueLabel;

	public UIEventListener btn_confirm;

	public UIEventListener btn_cancel;

	public UIEventListener btn_IconClick;

	public Action E_OnClose;

	public Action<Friend> E_OnIconClick;

	public Action<Friend> E_OnAddFriend;

	private Friend mFriend;

	private void Start()
	{
	}

	public void SetData(Friend _friendInfo)
	{
	}
}
