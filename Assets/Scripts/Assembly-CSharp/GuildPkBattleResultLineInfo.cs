using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class GuildPkBattleResultLineInfo
{
	public int Line;

	public bool IsWin;

	public bool HasFlag;

	public bool IsFirstRound;

	public List<GuildPkBattleResultCellInfo> Kills;

	public Dictionary<int, string> LeftNameDic;

	public Dictionary<int, string> RightNameDic;

	public string LeftForm;

	public string RightForm;

	public int LineBlocks => 0;

	public int LineBlocksWithFlag => 0;

	public bool NoFight => false;

	public GuildPkBattleResultLineInfo(CrossGuildBattleReportSummaryProto.LineResultProto _proto, bool _isFirstRound, Vector2Int _myPos)
	{
	}
}
