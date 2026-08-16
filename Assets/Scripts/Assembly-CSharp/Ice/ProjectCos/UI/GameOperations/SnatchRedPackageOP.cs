using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class SnatchRedPackageOP : Operation
	{
		public S2CRankingPickRedPackAck ACK;

		private C2SRedPackListReq.TypeEnum t;

		private int redPackID;

		public SnatchRedPackageOP(C2SRedPackListReq.TypeEnum t, int redPackID)
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
