namespace Ice.ProjectCos.UI.Intents
{
	public class SmeltJourneyTroopsSelectorIntent : IceUIIntent
	{
		public enum TradeMethod
		{
			Add = 0,
			Exchange = 1
		}

		private const string IntentKey = "UISmeltJourneryTroopsSelector";

		private const string ResCategory = "uismeltjournery";

		private TradeMethod method;

		private int fromSlot;

		public static bool AbleToPerform()
		{
			return false;
		}

		public SmeltJourneyTroopsSelectorIntent(TradeMethod m, int slot)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void handleRefresh()
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
