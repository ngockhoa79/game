using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public class PackageItemShop
	{
		public List<PkgItem> ShopList { get; private set; }

		public bool IsNeedRefresh { get; set; }

		public void CreateFromPackageShop()
		{
		}

		public void CreateFromItemShop()
		{
		}

		public void ReorderByCanBuy()
		{
		}
	}
}
