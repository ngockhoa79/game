using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class BattleSideFormation
{
	public int _PlayerId;

	public int _Line;

	public int _Column;

	public List<ReportHeroInfo> _HerosFormation;

	public int RealColumn;

	public HashSet<int> _LeaderId;

	public HashSet<int> _LeaderFighterIdSet;

	public BattleSideFormation(BattleFormationProto _info, bool _isLeft)
	{
	}

	public bool IsLeader(int _fighterId)
	{
		return false;
	}

	public int GetLeaderId()
	{
		return 0;
	}

	public int GetLine(int _fighterId)
	{
		return 0;
	}

	public List<ReportHeroInfo> GetColumnFighters(int _column)
	{
		return null;
	}

	public ReportHeroInfo GetHeroInfo(int _fighterId)
	{
		return null;
	}

	public int GetSupportTargetId(int _fighterId)
	{
		return 0;
	}

	private bool ColumnHasHero(int _column)
	{
		return false;
	}

	public void DestoryAll()
	{
	}
}
