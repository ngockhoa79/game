using System;
using Ice.ProjectCos.Protocol;

public class UIArRedPackItem : IceUIBase
{
	private const string BGSlotYellow = "UIPvPRPYellow";

	private const string BGSlotGray = "UIPvPRPGray";

	private const string CountSlotYellow = "UIPvPRPTxtCountSlot";

	private const string CountSlotGray = "UIPvPRPTxtCountSlotGray";

	public UISprite Vip;

	public UISprite Frame;

	public UISprite BGSlot;

	public UISprite TimerSprite;

	public UISprite DoneSprite;

	public UISprite CountSlot;

	public UITexture Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel TimeLabel;

	public UILabel CountLabel;

	public UILabel LastRank;

	public UILabel GuildName;

	public UIEventListener SnatchBtn;

	public IceAnimatorTotalCommander anim_active;

	public IceAnimatorTotalCommander anim_click;

	private bool isSelfCD;

	private Timer t;

	private RankingRedPackProto data;

	public bool IsSelfCD => false;

	private void clear()
	{
	}

	public void SetDetail(RankingRedPackProto proto, RedPackCoolDownTimeProto cd, Action onclick)
	{
	}

	private void activeCDInfo(bool active)
	{
	}

	public void ApplyCD(TimeSpan cd, bool minusOne)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void OnDestroy()
	{
	}

	private void stopTimer()
	{
	}
}
