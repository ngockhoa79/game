using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CreditShopBuyItemOp : Operation
	{
		private ShopItem mToBuy;

		private int mButCount;

		public CreditShopBuyItemOp(ShopItem si, int buyCount)
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
