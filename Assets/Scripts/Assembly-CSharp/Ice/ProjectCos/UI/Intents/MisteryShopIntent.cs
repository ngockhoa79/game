using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class MisteryShopIntent : ShopIntent
	{
		private ShopType mType;

		public MisteryShopIntent(ShopType type)
		{
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override string getUIName()
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}
	}
}
