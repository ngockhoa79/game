using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIArBattleReporterItem : IceUIBase
{
	private const string BattleReportChallenge = "UIPVPBRChallenge";

	private const string BattleReportDefense = "UIPVPBRDefense";

	public UISprite Profession;

	public UISprite Frame;

	public UISprite Direction;

	public UISprite Vip;

	public UITexture Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel TimeLabel;

	public UILabel GuildName;

	public UIArRankDrift Vectory;

	public UIArRankDrift Defeated;

	public UIEventListener ReplayBtn;

	private RankingBattleReportProto.ReportItemProto data;

	private int reportID;

	public RankingBattleReportProto.ReportItemProto Data
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

	private void set(RankingBattleReportProto.ReportItemProto data)
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

	private void handleError(object res, NetManager.CoreErrorCode err_code)
	{
	}

	protected override void DoDispose()
	{
	}
}
