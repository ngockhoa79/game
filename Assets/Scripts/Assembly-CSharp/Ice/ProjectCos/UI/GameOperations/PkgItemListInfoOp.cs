using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PkgItemListInfoOp : Operation
	{
		public C2SDiamondShopBuyReq.TypeEnum Type { get; set; }

		public PkgItemListInfoOp(C2SDiamondShopBuyReq.TypeEnum type)
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
