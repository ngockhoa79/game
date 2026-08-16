using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class GuildInfo
{
	public int Id;

	public string Name;

	public int Icon;

	public int Level;

	public int Exp;

	public int Members;

	public int PresidentId;

	public string Notice;

	public GuildMemberInfo MyInfo;

	public PlayerSummaryInfoProto PresidentInfo;

	public List<GuildMemberInfo> MemberList;

	public PlayerGuildInfoProto InfoOfPlayer;

	public string PresidentName;

	public int SearchRank;

	public bool Applied;

	public GuildMemberInfoProto.TypeEnum MyPost => default(GuildMemberInfoProto.TypeEnum);

	public GuildInfo(GuildAllInfoProto _proto)
	{
	}

	public GuildInfo(GuildSummaryInfoProto _proto)
	{
	}

	private void SetDataByBaseInfo(GuildInfoProto _proto)
	{
	}

	public void SetInfoOfPlayer(PlayerGuildInfoProto _proto)
	{
	}

	public bool ChangeMyPost(GuildMemberInfoProto.TypeEnum _post)
	{
		return false;
	}

	public bool ChangePost(int _playerId, GuildMemberInfoProto.TypeEnum _post)
	{
		return false;
	}

	public bool AddMember(GuildMemberInfoProto _proto)
	{
		return false;
	}

	public bool RemoveMember(int _playerId)
	{
		return false;
	}

	private GuildMemberInfo GetMemberInfo(int _playerId)
	{
		return null;
	}
}
