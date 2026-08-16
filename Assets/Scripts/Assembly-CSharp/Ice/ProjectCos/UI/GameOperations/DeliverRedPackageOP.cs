using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class DeliverRedPackageOP : Operation
	{
		public S2CRankingSendRedPacksAck ACK;

		private C2SRedPackListReq.TypeEnum t;

		public DeliverRedPackageOP(C2SRedPackListReq.TypeEnum t)
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
