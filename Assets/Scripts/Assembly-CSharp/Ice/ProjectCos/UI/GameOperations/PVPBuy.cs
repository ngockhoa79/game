using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PVPBuy : Operation
	{
		public S2CBuyFunctionAck ACK;

		private C2SBuyFunctionReq.TypeEnum t;

		public PVPBuy(C2SBuyFunctionReq.TypeEnum t)
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
