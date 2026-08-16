using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ShopListOp : Operation
	{
		public C2SShopListReq.TypeCode ShopType { get; set; }

		public ShopListOp(C2SShopListReq.TypeCode type)
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
