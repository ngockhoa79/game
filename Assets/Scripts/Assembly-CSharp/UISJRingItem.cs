using UnityEngine;

public class UISJRingItem : IceUIBase
{
	public GameObject MasterMisc;

	public GameObject HostMisc;

	public UISprite Profession;

	public UISprite Frame;

	public VIPLabel VipLabel;

	public UITexture Portrait;

	public UILabel LvText;

	public UILabel NameText;

	public UILabel Denominator;

	public UILabel Winning;

	public UILabel lbRanking;

	public UILabel GuildName;

	private Rect LayoutRect;

	private void clear()
	{
	}

	public void SetDetails(bool isManito, int heroid, string name, string guildName, int guildIcon, int lv, int viplevel, int denominator, string winning, int ranking)
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
}
