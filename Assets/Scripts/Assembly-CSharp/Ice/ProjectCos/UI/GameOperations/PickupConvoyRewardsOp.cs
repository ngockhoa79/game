using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PickupConvoyRewardsOp : Operation
	{
		public bool isOK;

		public List<ThingHolding> Rewards { get; private set; }

		public int Gold { get; private set; }

		public int Exp { get; private set; }

		public EscortPlayerInfoProto latestInfo { get; private set; }

		public List<EscortWrestRecordProto> lootRecords { get; private set; }

		public PickupConvoyRewardsOp()
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
