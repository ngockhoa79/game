using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class ShopItem
	{
		public int ShopIndex { get; set; }

		public int ID { get; set; }

		public int Price { get; set; }

		public string Name => null;

		public int BuyCount => 0;

		public CurrencyType PayType { get; set; }

		public bool IsAlreadyBuy { get; set; }

		public ItemHolding BuyItem { get; set; }

		public static ShopItem CreateFromProto(ShopInfoProto.ShopItemProto proto, int shopIndex)
		{
			return null;
		}

		public string GetNameNumDesc()
		{
			return null;
		}
	}
}
