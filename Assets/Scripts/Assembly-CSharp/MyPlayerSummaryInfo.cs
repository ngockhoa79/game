using Ice.ProjectCos.Protocol;

public class MyPlayerSummaryInfo
{
	public ulong PlayerId { get; private set; }

	public string Name { get; private set; }

	public int Level { get; private set; }

	public int LeaderId { get; private set; }

	public int CombatValue { get; private set; }

	public string GuildName { get; private set; }

	public int LeaderCombatValue { get; private set; }

	public int VipLevel { get; private set; }

	public int HeadId { get; private set; }

	public void LoadFromSummary(PlayerSummaryInfoProto proto)
	{
	}
}
