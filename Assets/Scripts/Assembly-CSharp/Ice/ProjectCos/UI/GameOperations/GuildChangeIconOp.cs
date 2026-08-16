namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildChangeIconOp : GuildInfoChangeOp
	{
		public int newIconID;

		public GuildChangeIconOp(int new_icon)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}
	}
}
