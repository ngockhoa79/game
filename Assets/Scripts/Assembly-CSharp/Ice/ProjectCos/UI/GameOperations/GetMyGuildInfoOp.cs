namespace Ice.ProjectCos.UI.GameOperations
{
	public class GetMyGuildInfoOp : Operation
	{
		public GetMyGuildInfoOp()
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
