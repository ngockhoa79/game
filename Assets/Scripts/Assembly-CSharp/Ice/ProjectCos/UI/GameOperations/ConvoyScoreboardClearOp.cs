namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoyScoreboardClearOp : Operation
	{
		public bool isOK;

		public ConvoyScoreboardClearOp()
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
