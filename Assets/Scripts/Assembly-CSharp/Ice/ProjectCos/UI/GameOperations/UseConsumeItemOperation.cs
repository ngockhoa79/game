using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class UseConsumeItemOperation : Operation
	{
		private int count;

		public ItemHolding ConsumeHolding { get; private set; }

		public UseConsumeItemOperation(ItemHolding holding)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public UseConsumeItemOperation(ItemHolding holding, int cnt)
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
