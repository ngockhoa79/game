using System;

public class UIConvoyReportItem : IceUIBase
{
	private const string Win = "Convoy4_report_icon_win";

	private const string Lose = "Convoy4_report_icon_lose";

	public UISprite WinOrLose;

	public UISprite Profession;

	public UISprite Frame;

	public UITexture Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel Tips;

	public VIPLabel VipInfo;

	public UIEventListener ReplayBtn;

	public UILabel TimeText;

	public UILabel GuildName;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	private int reportID;

	private int carID;

	private void clear()
	{
	}

	public void SetData(int heroID, string name, string guildName, int lv, int vip, bool isWin, int reportID, string carName, long time, int failPunish, bool isAttacker)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}
}
