namespace Ice.ProjectCos.UI.Intents
{
	public class ConvoyTroopsSelectorIntent : IceUIIntent
	{
		private const string IntentKey = "ConvoyTroopsSelector";

		private const string ResPanelKey = "UISmeltJourneryTroopsSelector";

		private const string ResCategory = "uismeltjournery";

		private SmeltJourneyTroopsSelectorIntent.TradeMethod method;

		public static bool AbleToPerform()
		{
			return false;
		}

		public ConvoyTroopsSelectorIntent(SmeltJourneyTroopsSelectorIntent.TradeMethod m)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void handleOnBack()
		{
		}

		private void handleOnHome()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
