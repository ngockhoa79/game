using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouPickupBattleRewardOp : Operation
	{
		public S2CrossPersonPickBattleRewardAck ACK;

		public List<ThingHolding> RewardItems;

		public ThingHolding FakeItem1;

		public ThingHolding FakeItem2;

		public ThingHolding FakeItem3;

		public MakyouPickupBattleRewardOp()
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
