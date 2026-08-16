using System;
using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.DataModel
{
	public class Shop : DataModelList<ShopItem>
	{
		private List<int> mRefreshHour;

		private List<int> mRefreshMin;

		private ShopGeneralTemplate mTmp;

		public ShopType Type { get; private set; }

		public bool CanBuy { get; set; }

		public int RefreshCount { get; private set; }

		public static int RefreshCountMax => 0;

		public int RefreshCountRest => 0;

		public bool CanRefresh => false;

		public List<ShopItem> ShopItemList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Shop(C2SShopListReq.TypeCode type)
		{
		}

		public Shop(ShopType type)
		{
		}

		public int GetShopRefreshCost()
		{
			return 0;
		}

		public int GetShopRefreshCostType()
		{
			return 0;
		}

		public int GetChallageFormationID()
		{
			return 0;
		}

		public static ShopType ConvertClientType(C2SShopListReq.TypeCode type)
		{
			return default(ShopType);
		}

		public static C2SShopListReq.TypeCode ConvertServerType(ShopType type)
		{
			return default(C2SShopListReq.TypeCode);
		}

		private int findFormationID(int shopId)
		{
			return 0;
		}

		public void CreateFromProto(S2CShopListAck po)
		{
		}

		private void findTemplate()
		{
		}

		private void loadRereshTime()
		{
		}

		public DateTime GetNextRefreshTime()
		{
			return default(DateTime);
		}
	}
}
