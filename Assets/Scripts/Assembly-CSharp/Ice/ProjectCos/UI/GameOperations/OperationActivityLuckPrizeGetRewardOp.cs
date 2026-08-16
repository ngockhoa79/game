namespace Ice.ProjectCos.UI.GameOperations
{
	public class OperationActivityLuckPrizeGetRewardOp : Operation
	{
		public OperationActivityLuckPrizeGetRewardOp()
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
