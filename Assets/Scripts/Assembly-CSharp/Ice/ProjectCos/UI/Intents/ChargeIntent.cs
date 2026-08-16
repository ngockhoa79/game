namespace Ice.ProjectCos.UI.Intents
{
	public class ChargeIntent : IceUIIntent
	{
		private const string IntentKeyword = "ChargeUI";

		public bool AbleToPerform()
		{
			return false;
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
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
