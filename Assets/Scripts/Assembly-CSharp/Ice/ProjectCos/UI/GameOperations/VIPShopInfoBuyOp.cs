using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class VIPShopInfoBuyOp : Operation
	{
		public S2CWeekVipGiftPickAck ACK;

		protected int PackageIndex;

		public List<ThingHolding> Rewards { get; private set; }

		public VIPShopInfoBuyOp(int index)
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
