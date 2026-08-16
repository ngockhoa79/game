using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;

public class UIGuildPartyScrollingBoard : UIScrollingBoardBase<UIGuildPartyBoardItem, GuildPartyInfoProto.PartyRecordProto>
{
	public const string PartyRes = "Guild_Party_NTF";

	private GuildPartyTemplate t;

	public void SetTemplate(GuildPartyTemplate t)
	{
	}

	public override void SetBoard(List<GuildPartyInfoProto.PartyRecordProto> data)
	{
	}

	public GuildPartyInfoProto.PartyRecordProto CreateData()
	{
		return null;
	}

	public override UIGuildPartyBoardItem createOneLine(GuildPartyInfoProto.PartyRecordProto proto, UIGuildPartyBoardItem input)
	{
		return null;
	}

	private string getXianDouDesc(GuildPartyTemplate.ItemBonus_ bonus)
	{
		return null;
	}
}
