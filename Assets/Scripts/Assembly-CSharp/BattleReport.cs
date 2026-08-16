using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class BattleReport
{
	public static int Left_Size;

	public BattleSideFormation _LeftFormation;

	public BattleSideFormation _RightFormation;

	public List<BattleRoundInfo> _Rounds;

	public BattleReportProto OriginReport;

	public bool LeftWin;

	public void DestoryAll()
	{
	}

	public BattleReport(BattleReportProto _info)
	{
	}

	public int GetSideHeroCount(bool _left)
	{
		return 0;
	}

	public int GetLine(int _fighterId)
	{
		return 0;
	}

	public ReportHeroInfo GetFighterInfo(int _fighterId)
	{
		return null;
	}

	public List<ReportHeroInfo> GetColumnFighters(int _column, bool _left)
	{
		return null;
	}

	public int GetSupportTargetId(int _fighterId)
	{
		return 0;
	}

	public bool IsLeader(int _fighterId)
	{
		return false;
	}

	public bool IsPasser(int _fighterId)
	{
		return false;
	}

	public bool HasSupportTeammate(int _fighterId)
	{
		return false;
	}

	public bool IsLeft(int _fighterId)
	{
		return false;
	}
}
