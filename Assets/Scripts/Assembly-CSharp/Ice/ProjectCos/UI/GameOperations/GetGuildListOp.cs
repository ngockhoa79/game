namespace Ice.ProjectCos.UI.GameOperations
{
	public class GetGuildListOp : Operation
	{
		private int pageIndex;

		public GetGuildListOp(int _pageIndex)
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
