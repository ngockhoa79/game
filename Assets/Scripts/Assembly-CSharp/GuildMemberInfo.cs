using Ice.ProjectCos.Protocol;

public class GuildMemberInfo
{
	public int Id;

	public string Name;

	public int HeadIcon;

	public int Level;

	public int Vip;

	public int CombatValue;

	public int LeaderId;

	public bool IsOnline;

	public long LastLoginTime;

	public bool IsBuild;

	public int Contribution;

	public GuildMemberInfoProto.TypeEnum Post;

	public GuildMemberInfoProto rawData;

	public GuildMemberInfo(GuildMemberInfoProto _proto)
	{
	}
}
