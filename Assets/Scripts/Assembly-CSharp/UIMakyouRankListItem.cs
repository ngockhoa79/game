using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

public class UIMakyouRankListItem : IceUIBase
{
	private int RankSpriteDepth;

	private int TopTen;

	private const string BadgePrefix = "UIPvPBadge";

	private const string BGPrefix = "UIPvPRLItemBG";

	private const string UIPvPRank = "UIPvPRank";

	private const string UIPvPRank10 = "UIPvPRank10";

	private const string UIPvPRankMediocre = "UIPvPRankMediocre";

	public UISprite Badge;

	public UISprite Profession;

	public UISprite Frame;

	public UISprite BG;

	public UISprite VIP;

	public UITexture Portrait;

	public UILabel NameText;

	public UILabel PowerText;

	public Transform RankCentralAxis;

	private List<UISprite> rankSprites;

	public UILabel lbSupporterCount;

	public UILabel lbReal;

	public CrossPersonPlayOffBetRankingProto.RankingItemProto playerInfo
	{
		set
		{
		}
	}

	private void clear()
	{
	}

	private void set(CrossPersonPlayOffBetRankingProto.RankingItemProto playerInfo)
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

	private void simplifyRankSymbols(int rank)
	{
	}

	private string rankToSpriteName(int rank)
	{
		return null;
	}

	private UISprite createOneSprite(int rank, Transform parent, char name, int depth)
	{
		return null;
	}

	private void repositionAndScale()
	{
	}

	private float wholeWidth()
	{
		return 0f;
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
