using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FetchSmeltJourneyWinningsOperation : Operation
	{
		public S2CTrialChallengeWinningAck ACK;

		public FetchSmeltJourneyWinningsOperation()
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
