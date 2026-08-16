using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class PkgItem
	{
		private int mBuyLimitToday;

		private string mDescKey;

		public C2SDiamondShopBuyReq.TypeEnum Type { get; private set; }

		public int ID { get; private set; }

		public string Name { get; private set; }

		public int PriceOrigin { get; private set; }

		public int PriceNow { get; private set; }

		public int Price => 0;

		public bool IsPromotion => false;

		public bool IsNew { get; private set; }

		public bool IsHot { get; private set; }

		public int VIPLimit { get; private set; }

		public int BuyCountToday { get; set; }

		public int BuyCountRestToday => 0;

		public int BuyLimitTotal { get; private set; }

		public int BuyLimitToday => 0;

		public bool IsLimitedByVip => false;

		public bool IsLimitDaily => false;

		public bool CanBuyToday => false;

		public string IconName { get; private set; }

		public List<ThingHolding> BuyItems { get; private set; }

		public string Desc => null;

		public bool IsMyVipCanBuy()
		{
			return false;
		}

		public static PkgItem CreateFromItemShop(DiamondItemTemplate tmp)
		{
			return null;
		}

		public string GetNameNumDesc()
		{
			return null;
		}

		public static PkgItem CreateFromPackageShop(DiamondGiftTemplate tmp)
		{
			return null;
		}
	}
}
