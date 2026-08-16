using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouPickupRegularRewardOp : Operation
	{
		public S2CCrossPersonPickScoreRankingAck ACK;

		public List<ThingHolding> RewardItems;

		public MakyouPickupRegularRewardOp()
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
