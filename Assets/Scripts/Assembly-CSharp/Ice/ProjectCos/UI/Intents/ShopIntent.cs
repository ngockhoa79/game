namespace Ice.ProjectCos.UI.Intents
{
	public abstract class ShopIntent : SimpUIIntent
	{
		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override string getUIType()
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
