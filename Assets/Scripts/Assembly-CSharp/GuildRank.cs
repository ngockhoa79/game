using System;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class GuildRank : IceUIBase
{
	public class CardItemVisualizer : IceUIReusableList<GuildSummaryInfoProto>.IVisualizer
	{
		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, GuildSummaryInfoProto guildInfo)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class GuildBatterItemVisualizer : IceUIReusableList<CrossGuildScoreRakingingProto.RankingItemProto>.IVisualizer
	{
		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, CrossGuildScoreRakingingProto.RankingItemProto guildInfo)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public Action E_OnClose;

	[SerializeField]
	private UILabel lbGuildName;

	[SerializeField]
	private UILabel lbGuildScore;

	[SerializeField]
	private UILabel lbGuildBattScore;

	[SerializeField]
	private UILabel lbRewardTip;

	[SerializeField]
	private UILabel lbRank;

	[SerializeField]
	private UIEventListener btnClose;

	[SerializeField]
	private GuildRankList List;

	[SerializeField]
	private IceAnimatorTotalCommander anim_in;

	[SerializeField]
	private GameObject guildLevel;

	[SerializeField]
	private GameObject guildBatter;

	[SerializeField]
	private IceUIBtnGroup tabs;

	[SerializeField]
	private GuildRankBatterList batterList;

	[SerializeField]
	private UIEventListener helpBtn;

	private string CurrentTab;

	private int CurrentIndex;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void onCLickHelp(GameObject obj)
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void setStatus(string oldBtnName, string newBtnName)
	{
	}

	private void onchangeTab(int tab)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void __request_batter_info_()
	{
	}

	private void _refresh_batter_view_(S2CCrossGuildScoreRankingAck ack)
	{
	}

	private void __request_info_()
	{
	}

	private void _refresh_view_(S2CGuildRankingAck ack)
	{
	}
}
