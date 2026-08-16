using System;
using Ice.ProjectCos.Protocol;

public class GuildRankBatterListItem : IceUIBase
{
	private const string BGPrefix = "RankItemBg";

	public RankNumberDisplayer RankShow;

	public UISprite BG;

	public UISprite GuildIcon;

	public UILabel GuildName;

	public UILabel lbSucc;

	public UILabel ActivityValue;

	public UILabel lbReal;

	public UILabel GuildLv;

	public IceAnimatorTotalCommander anim_in;

	public CrossGuildScoreRakingingProto.RankingItemProto GuildInfo
	{
		set
		{
		}
	}

	private void clear()
	{
	}

	private void set(CrossGuildScoreRakingingProto.RankingItemProto guildInfo)
	{
	}

	private string rankID(int rank)
	{
		return null;
	}

	private bool isTopThree(int rank)
	{
		return false;
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

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}
}
