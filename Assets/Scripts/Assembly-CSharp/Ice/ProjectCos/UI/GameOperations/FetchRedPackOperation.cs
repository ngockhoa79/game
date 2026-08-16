using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FetchRedPackOperation : Operation
	{
		public S2CRedPackListAck ACK;

		private C2SRedPackListReq.TypeEnum t;

		public FetchRedPackOperation(C2SRedPackListReq.TypeEnum t)
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
