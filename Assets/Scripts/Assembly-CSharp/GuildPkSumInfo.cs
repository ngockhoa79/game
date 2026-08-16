using Ice.ProjectCos.Protocol;

public class GuildPkSumInfo
{
	public bool HasInfo;

	public int Id;

	public int Icon;

	public string Name;

	public int Server;

	public int FightMems;

	public int SeasonWinCount;

	public int Round1Score;

	public int Round2Score;

	public int TotalScore => 0;

	public GuildPkSumInfo(CrossGuildInfoProto.PrevSeasonItemProto _proto)
	{
	}

	public GuildPkSumInfo(CrossGuildFormationProto.GuildInfoProto _proto)
	{
	}

	public void SetFightMems(int _members)
	{
	}
}
