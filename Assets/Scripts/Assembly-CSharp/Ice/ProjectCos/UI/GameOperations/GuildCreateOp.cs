namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildCreateOp : Operation
	{
		private string Name;

		private int Icon;

		public GuildCreateOp(string _name, int _icon)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}
