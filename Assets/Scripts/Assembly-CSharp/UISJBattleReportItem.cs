using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UISJBattleReportItem : IceUIBase
{
	private const string Win = "UISJBattleReportTxtVectory";

	private const string Lose = "UISJBattleReportTxtFail";

	public UISprite WinOfLose;

	public UISprite Profession;

	public UISprite Frame;

	public UISprite spVip;

	public UITexture Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel GuildName;

	public UILabel lbTime;

	public UIEventListener ReplayBtn;

	private int reportID;

	private C2STrialReportDetailReq.TypeEnum t;

	[SerializeField]
	private UISprite spItemBg;

	[SerializeField]
	private UISprite spTitleBg;

	public bool IsSuper
	{
		set
		{
		}
	}

	private void clear()
	{
	}

	public void SetDetails(int heroID, string name, string guildName, int lv, bool isWin, int reportID, DateTime dt, C2STrialReportDetailReq.TypeEnum t, int vip = 0)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void handleReq(GameObject btn)
	{
	}

	private BattleReport createBattleReport(BattleReportProto proto)
	{
		return null;
	}

	private void popMsg(string msg = "当前操作产生未知错误")
	{
	}

	protected override void DoDispose()
	{
	}
}
