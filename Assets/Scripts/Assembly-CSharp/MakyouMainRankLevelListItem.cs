using System;
using Ice.ProjectCos.ConfigGenerator.Template;

public class MakyouMainRankLevelListItem : IceUIBase
{
	private const string BGPrefix = "RankItemBg";

	public UISprite BG;

	public UISprite spLevel;

	public UISprite spLevelTitle;

	public UILabel lbScore;

	public UILabel lbCrystil;

	public IceAnimatorTotalCommander anim_in;

	public CrossPersonGroupTemplate DataInfo
	{
		set
		{
		}
	}

	private void set(CrossPersonGroupTemplate proto)
	{
	}

	private int ResetCount(int Score)
	{
		return 0;
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
