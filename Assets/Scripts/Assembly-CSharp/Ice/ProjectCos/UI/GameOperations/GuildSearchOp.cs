namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildSearchOp : Operation
	{
		private string Sign;

		public GuildSearchOp(string _sign)
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
