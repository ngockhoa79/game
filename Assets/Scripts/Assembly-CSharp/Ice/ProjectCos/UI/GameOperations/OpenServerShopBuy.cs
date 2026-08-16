using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class OpenServerShopBuy : Operation
	{
		public S2COpenServerShopBuyAck ACK;

		private int index;

		private int count;

		public OpenServerShopBuy(int index, int count)
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
