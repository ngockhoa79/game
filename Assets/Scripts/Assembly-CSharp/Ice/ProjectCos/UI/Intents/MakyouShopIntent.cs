using System;

namespace Ice.ProjectCos.UI.Intents
{
	public class MakyouShopIntent : ShopIntent
	{
		public Action OnClose;

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
