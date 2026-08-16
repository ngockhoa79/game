namespace Ice.ProjectCos.UI.GameOperations
{
	public class RechargeRewardPickOp : Operation
	{
		private int _index;

		public RechargeRewardPickOp(int index)
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
