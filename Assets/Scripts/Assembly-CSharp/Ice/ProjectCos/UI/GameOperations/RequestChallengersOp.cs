using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RequestChallengersOp : Operation
	{
		public class PVPOperationData
		{
			public S2CRankIngListAck.ResultCode Result;

			public int OwnRank;

			public int UsedChallengeTimes;

			public int BoughtChallengeTimes;

			public int Reputation;

			public FixedList<PVPPlayer> Challengers;

			public long ChallengeCoolDownOverTime;

			public PVPOperationData(S2CRankIngListAck ack)
			{
			}
		}

		public PVPOperationData OperationData;

		private List<PVPPlayer> challengers;

		private bool isForceRefresh;

		public RequestChallengersOp(bool isForceRefesh)
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

		private void addChallengers(List<RankingerInfoProto> infoProto, bool revenge = false)
		{
		}
	}
}
