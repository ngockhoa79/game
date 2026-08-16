using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PVPFetchRankSequenceOP : Operation
	{
		public S2CRequirePVPRankAck ACK { get; private set; }

		public List<PlayerSummaryInfoProto> RankSequence { get; private set; }

		public PVPFetchRankSequenceOP()
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
