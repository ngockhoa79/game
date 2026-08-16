using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class GameShop
	{
		private Shop mRefineShop;

		private Shop mMysteryShop1;

		private Shop mMysteryShop2;

		private Shop mMysteryShop3;

		private Shop mPVPShop;

		private Shop mTrailShop;

		private Shop mCreditShop;

		private Shop mGuildShop;

		private Shop mMakyouShop;

		private Dictionary<int, ShopType> mShopDict;

		public Shop RefineShop => null;

		public Shop MysteryShop1 => null;

		public Shop MysteryShop2 => null;

		public Shop MysteryShop3 => null;

		public Shop PVPShop => null;

		public Shop TrailShop => null;

		public Shop CreditShop => null;

		public Shop GuildShop => null;

		public Shop MakyouShop => null;

		public DateTime MysteryDispearTime { get; private set; }

		public long MysteryDispearTimeTick { get; private set; }

		public bool ShowMisteryPopup { get; set; }

		public ShopType GetShopTypeByShopID(int shopID)
		{
			return default(ShopType);
		}

		public int GetMinIDByShopType(ShopType shopType)
		{
			return 0;
		}

		public Shop GetShopList(ShopType shopType)
		{
			return null;
		}

		public void UpdateStatusFromProto(ShopPveAppearProto proto)
		{
		}

		public bool CanOpenMisteryShop()
		{
			return false;
		}
	}
}
