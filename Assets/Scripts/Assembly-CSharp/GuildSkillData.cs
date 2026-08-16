using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class GuildSkillData
{
	public int Level;

	public UIGuildSkillItem.EState Type;

	public List<PlayerGuildInfoProto.BuffProto> Data;

	public GuildSkillData(int lv, UIGuildSkillItem.EState t, List<PlayerGuildInfoProto.BuffProto> d)
	{
	}
}
