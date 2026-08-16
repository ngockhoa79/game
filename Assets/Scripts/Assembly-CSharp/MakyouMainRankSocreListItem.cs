using System;
using Ice.ProjectCos.Protocol;

public class MakyouMainRankSocreListItem : IceUIBase
{
	private const string BGPrefix = "RankItemBg";

	public RankNumberDisplayer RankShow;

	public UISprite Profession;

	public UISprite Frame;

	public UISprite spVip;

	public UISprite badgeIcon;

	public UITexture Portrait;

	public UISprite BG;

	public UILabel lbname;

	public UILabel lbActivityValue;

	public UILabel lbpower;

	public UILabel lbRealNum;

	public UILabel lblevel;

	public UILabel lbSuccRate;

	public IceAnimatorTotalCommander anim_in;

	public CrossPersonRankingItemProto GuildInfo
	{
		set
		{
		}
	}

	private void set(CrossPersonRankingItemProto proto)
	{
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
