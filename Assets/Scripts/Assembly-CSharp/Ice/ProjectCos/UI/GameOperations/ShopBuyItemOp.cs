using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ShopBuyItemOp : Operation
	{
		public C2SShopListReq.TypeCode ShopType { get; set; }

		public ShopItem ShopItemToBuy { get; set; }

		public ShopBuyItemOp()
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		public void SetTypeRefine()
		{
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}
