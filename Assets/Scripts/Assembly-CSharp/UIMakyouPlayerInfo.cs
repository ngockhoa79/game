using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIMakyouPlayerInfo : IceUIBase
{
	public UIEventListener CloseButton;

	public MakyouBadge Badge;

	public UILabel PlayerName;

	public UILabel PlayerLevel;

	public UILabel PlayerServer;

	public UILabel PlayerPower;

	public UILabel LabelPoint;

	public UILabel LabelRank;

	public UILabel LabelWinRate;

	public UILabel LabelComboWin;

	public UILabel LabelChallengeWin;

	public UILabel LabelChallengeLose;

	public UILabel LabelDefenseWin;

	public UILabel LabelDefenseLose;

	public UILabel LabelHistoryPoint;

	public UILabel LabelHistoryRank;

	public UILabel LabelHistoryWinRate;

	public UILabel LabelHistoryLevel;

	private CrossPersonTargetInfoProto PlayerInfoData;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void SetData(CrossPersonTargetInfoProto playerInfo)
	{
	}

	private void OnClose(GameObject btn)
	{
	}
}
