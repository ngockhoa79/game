using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ObtainSmeltJourneyTreasureOperation : Operation
	{
		public S2CTrialStageRewardAck ACK;

		private int _superIndex;

		public ObtainSmeltJourneyTreasureOperation(int superIndex)
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
