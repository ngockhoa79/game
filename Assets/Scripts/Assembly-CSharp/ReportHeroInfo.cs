using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class ReportHeroInfo
{
	public class ReportHeroLineComparer : IComparer<ReportHeroInfo>
	{
		public int Compare(ReportHeroInfo x, ReportHeroInfo y)
		{
			return 0;
		}
	}

	public class ReportHeroFighterIdComparer : IComparer<ReportHeroInfo>
	{
		public int Compare(ReportHeroInfo x, ReportHeroInfo y)
		{
			return 0;
		}
	}

	public PlayerHeroPropertyInfo _PropertyBaseInfo;

	public int PlayerId;

	public List<ReportSkillInfo> _Skills;

	public bool isLeft;

	public int Line;

	public BattleSmallLineType SmallLine;

	public int Column;

	public int FighterId;

	public int HeroId;

	public bool hasBoneEffect;

	public bool isPasser;

	public ReportHeroInfo(PlayerHeroInfoProto _info, int _index, int _totalLine, int _totalColumn, bool _isLeft, bool _hasBoneEffect)
	{
	}

	public ReportHeroInfo()
	{
	}

	public void InitForStory(int _heroId, int _fighterId, bool _left)
	{
	}

	public void SetPosition(int _line, int _column)
	{
	}
}
