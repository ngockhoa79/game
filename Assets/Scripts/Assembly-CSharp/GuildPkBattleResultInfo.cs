using System;
using Ice.ProjectCos.Protocol;

public class GuildPkBattleResultInfo
{
	public GuildPkBattleResultLineInfo[] Lines;

	public DateTime FightPoint;

	public bool IsFirstRound;

	public int TotalBlocks => 0;

	public int TotalBlocksWithFlg => 0;

	public Vector2Int GetLineAndCellByCounter(int _counter)
	{
		return default(Vector2Int);
	}

	public GuildPkBattleResultInfo(CrossGuildBattleReportSummaryProto _proto)
	{
	}
}
