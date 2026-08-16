using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class BatchUseConsumeItemOperation : Operation
	{
		public List<ItemHolding> ConsumeItems { get; private set; }

		public BatchUseConsumeItemOperation(List<ItemHolding> holdings)
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
