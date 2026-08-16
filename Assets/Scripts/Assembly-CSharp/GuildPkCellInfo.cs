using Ice.ProjectCos.Protocol;

public class GuildPkCellInfo
{
	public int line;

	public int index;

	public int playerId;

	public int headicon;

	public string name;

	public int battlePower;

	public int lv;

	public int vip;

	public bool isMyCell;

	public PlayerSummaryInfoProto summaryInfo;

	public GuildPkCellInfo(S2CCrossGuildLineInfoAck.CellPlayerInfoProto _proto, bool _isMyCell, int _line)
	{
	}
}
