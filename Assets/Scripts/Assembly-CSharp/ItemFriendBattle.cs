using Ice.ProjectCos.Protocol;
using UnityEngine;

public class ItemFriendBattle : IceUIBase
{
	public UIAeCardDisplayer Header;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel TimeLabel;

	public UILabel GuildName;

	public UIEventListener ReplayBtn;

	public GameObject goWin;

	public GameObject goLose;

	public GameObject goChallage;

	public GameObject goBeChallage;

	private FriendBattleReportProto.ReportItemProto data;

	private int mBattleReportID;

	public FriendBattleReportProto.ReportItemProto Data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void clear()
	{
	}

	private void set(FriendBattleReportProto.ReportItemProto data)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void handleBattleReportData(GameObject btn)
	{
	}

	protected override void DoDispose()
	{
	}

	private void showBattleLog()
	{
	}
}
