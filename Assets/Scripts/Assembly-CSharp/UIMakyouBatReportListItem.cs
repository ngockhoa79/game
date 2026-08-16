using System;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIMakyouBatReportListItem : IceUIBase
{
	public UISprite Profession;

	public UISprite Frame;

	public UISprite Vip;

	public UITexture Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel TimeLabel;

	public UILabel realLabel;

	public UILabel lbscore;

	public UILabel lbAttack;

	public UIMakyouRankDrift Vectory;

	public UIMakyouRankDrift Defeated;

	public UIEventListener ReplayBtn;

	private int reportID;

	private MakyouBatterReportItemStruct data;

	public void SetData(MakyouBatterReportItemStruct data)
	{
	}

	private void clear()
	{
	}

	private void set(S2CCrossPersonBattleReportAck.ReportItemProto data)
	{
	}

	private void handleBattleReportData(GameObject btn)
	{
	}

	private void handleError(object res, NetManager.CoreErrorCode err_code)
	{
	}

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

	protected override void DoDestroy()
	{
	}
}
