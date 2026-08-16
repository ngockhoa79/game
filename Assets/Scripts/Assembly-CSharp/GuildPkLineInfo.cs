using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class GuildPkLineInfo
{
	public int Line;

	public GuildPkCellInfo[] cells;

	public int MyColumn;

	public void SetData(List<S2CCrossGuildLineInfoAck.CellPlayerInfoProto> _cells, int _mycolumn, int _line)
	{
	}
}
