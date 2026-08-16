using Ice.ProjectCos.ConfigGenerator.Template;

public class GuildMissionItem
{
	public GuildTaskTemplate template;

	public int current;

	public string TaskName => null;

	public string RewardDesc => null;

	private GuildTaskTextTemplate TaskText => null;

	public GuildMissionItem(GuildTaskTemplate t, int current)
	{
	}
}
