namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildChangeAnnoucementOp : GuildInfoChangeOp
	{
		public string newAnnouce;

		public GuildChangeAnnoucementOp(string new_announcement)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}
	}
}
