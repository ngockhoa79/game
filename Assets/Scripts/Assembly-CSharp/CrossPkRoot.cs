using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class CrossPkRoot : IceUIBase
{
	public GameObject LineRoot;

	public UIScrollBar LineScrollBar;

	public CrossPkSumHeadInfoCtrller MyGuildInfo;

	public CrossPkSumHeadInfoCtrller TargetGuildInfo;

	public GuildPkRootCenterCtrller CenterCtrller;

	public CrossPkZoomCtrller ZoomCtrller;

	public CrossPkReplayPanel ReplayCtrller;

	public IceAnimatorTotalCommander winAnim;

	public IceAnimatorTotalCommander drawAnim;

	public IceAnimatorTotalCommander loseAnim;

	public GameObject ResultRoot;

	private CrossPkBattleResultCtrller ResultCtrller;

	public UIEventListener RebornBtn;

	public UIEventListener RankBtn;

	public UIEventListener ScoreBtn;

	public UIEventListener ShopBtn;

	public UIEventListener HomeBtn;

	public UIEventListener ReturnBtn;

	public UIEventListener HelpBtn;

	private GuildPkFormationInfo formInfo;

	private CrossGuildBattleOverPlayerRewardProto rewardInfo;

	private CrossPkLineCtrller[] lines;

	private GuildPkLineInfo lineInfo;

	private GuildPkBattleResultInfo resultInfo;

	private float[] PlayLineFightTimes;

	private GuildPkLineReplayInfo replayInfo;

	private const float MAX_FIGHT_TIME = 600f;

	public void SetData(CrossGuildFormationProto _data, CrossGuildBattleOverPlayerRewardProto _reward)
	{
	}

	public void SetFormation(CrossGuildFormationProto _data)
	{
	}

	private new void Init()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshFormation()
	{
	}

	private void ReqFormationInfo()
	{
	}

	private void ReqBattleResult()
	{
	}

	public void ReqLineInfo(int _line)
	{
	}

	public void ReqLineReplayInfo(int _line)
	{
	}

	public void RefreshStatus()
	{
	}

	public void AddScore(int _left, int _right)
	{
	}

	public void ClearReward()
	{
	}

	public void PlayLineResultAnim(GuildPkData.LineFightResult _result)
	{
	}

	private void ResetLineResultAnims()
	{
	}

	private void SetLinesClickAble(bool _enable)
	{
	}

	public void LineFightOver(int _line)
	{
	}

	private void RollToLine(int _line)
	{
	}

	private void SetScore(bool _needPlayFight)
	{
	}

	private void ShowReplayBtns(bool _show)
	{
	}

	private void ShowPlayerAward()
	{
	}

	private void PlayBattleResult(CrossGuildBattleReportSummaryProto _proto)
	{
	}

	private void RecoverBattleForm()
	{
	}

	private void ShowLineInfo(S2CCrossGuildLineInfoAck _ack, int _line)
	{
	}

	private void ShowReplayPanel(CrossGuildReplayProto _proto, int _line)
	{
	}

	private void HandleFormationChangeNtf(object _ntf, int _msgId)
	{
	}

	private void CalCurrentFightBlock()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoShowOffscreen()
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

	private void tip(string t)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnRebornBtnClicked(GameObject obj)
	{
	}

	private void reqRelive()
	{
	}

	private void OnRankBtnClicked(GameObject obj)
	{
	}

	private void OnScoreBtnClicked(GameObject obj)
	{
	}

	private void OnShopBtnClicked(GameObject obj)
	{
	}

	private void OnHelpClicked(GameObject obj)
	{
	}
}
