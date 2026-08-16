using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public abstract class ShopAwardPreviewBase
	{
		protected Dictionary<int, ShopAwardData> mAwardByType;

		public ShopAwardData[] GetAll()
		{
			return null;
		}

		public abstract void Load();
	}
}
