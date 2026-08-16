namespace Ice.ProjectCos.UI.GameOperations
{
	public class ContinueRechargeRewardInfoOp : Operation
	{
		public ContinueRechargeRewardInfoOp()
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
