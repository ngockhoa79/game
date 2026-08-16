using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RequestSmeltJourneyRecordOperation : Operation
	{
		public S2CTrialRecordInfoAck ACK;

		public RequestSmeltJourneyRecordOperation()
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
