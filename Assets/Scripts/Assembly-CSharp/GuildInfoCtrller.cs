using System;
using UnityEngine;

public class GuildInfoCtrller : MonoBehaviour
{
	public GuildInfoDataCtrller DataGroup;

	public GuildInfoMemberListCtrller MemberGroup;

	public UIEventListener ChangeNoticeBtn;

	public Action E_OnInfoChange;

	public GuildChangeNoticeCtrller ChangeNoticeWindow;

	public void Prepare()
	{
	}

	public void SetData(int tabIndex)
	{
	}

	public void RefreshData()
	{
	}

	public void ClearData()
	{
	}

	private void OnChangeNoticeClicked(GameObject _object)
	{
	}

	public static int FormatContribution(int c)
	{
		return 0;
	}
}
