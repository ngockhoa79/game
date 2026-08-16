using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RefreshSmeltJourneyStrangersOperation : Operation
	{
		public S2CTrialRefreshStrangerAck ACK;

		public RefreshSmeltJourneyStrangersOperation()
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
