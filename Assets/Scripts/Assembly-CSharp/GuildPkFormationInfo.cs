using System;
using Ice.ProjectCos.Protocol;

public class GuildPkFormationInfo
{
	public bool NoFormation;

	public bool MeDeadAlready;

	public CrossGuildInfoProto.StatusEnum status;

	public DateTime overTime;

	public DateTime lastBattleTime;

	public string[] LeftLines;

	public string[] RightLine;

	public GuildPkLineFlagType[] LineFlags;

	public int MyLine;

	public int MyColumn;

	public GuildPkSumInfo myGuild;

	public GuildPkSumInfo targetGuild;

	public int reliveStone;

	public GuildPkFormationInfo(CrossGuildFormationProto _proto)
	{
	}

	public void SetData(CrossGuildFormationProto _proto)
	{
	}

	private GuildPkLineFlagType ConvertToFlagType(CrossGuildFormationProto.LineResultEnum _flag)
	{
		return default(GuildPkLineFlagType);
	}

	public void SetFormation(CrossGuildFormationBinaryDataProto _proto)
	{
	}
}
