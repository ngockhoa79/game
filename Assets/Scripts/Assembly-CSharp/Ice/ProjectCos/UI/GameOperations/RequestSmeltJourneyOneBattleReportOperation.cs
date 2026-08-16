using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RequestSmeltJourneyOneBattleReportOperation : Operation
	{
		public S2CTrialReportDetailAck ACK;

		private int reportID;

		private C2STrialReportDetailReq.TypeEnum t;

		public RequestSmeltJourneyOneBattleReportOperation(int reportID, C2STrialReportDetailReq.TypeEnum t)
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
