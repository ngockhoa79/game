using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class UIGuildConstructionScrollingBoard : UIScrollingBoardBase<UIGuildConstructionBoardItem, GuildDonateInfoProto.DonateRecordProto>
{
	public const string ConstructionRes = "Guild_Construction_NTF";

	public override void SetBoard(List<GuildDonateInfoProto.DonateRecordProto> data)
	{
	}

	public override UIGuildConstructionBoardItem createOneLine(GuildDonateInfoProto.DonateRecordProto proto, UIGuildConstructionBoardItem input)
	{
		return null;
	}

	public GuildDonateInfoProto.DonateRecordProto CreateData(int id, string name, GuildMemberInfoProto.TypeEnum post)
	{
		return null;
	}
}
