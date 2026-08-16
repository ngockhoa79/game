namespace Ice.ProjectCos.UI.Intents
{
	public class PVPShopIntent : ShopIntent
	{
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
