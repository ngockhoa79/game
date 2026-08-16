namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildChangeNameOp : GuildInfoChangeOp
	{
		public string newName;

		public GuildChangeNameOp(string new_name)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}
	}
}
