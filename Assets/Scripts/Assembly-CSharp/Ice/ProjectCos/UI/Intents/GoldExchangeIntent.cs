namespace Ice.ProjectCos.UI.Intents
{
	public class GoldExchangeIntent : SimpUIIntent
	{
		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override string getUIName()
		{
			return null;
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
