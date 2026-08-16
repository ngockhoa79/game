namespace Ice.ProjectCos.UI.Intents
{
	public class UISmeltJourneyRingStructureIntent : IceUIIntent
	{
		private const string IntentKey = "UISmeltJourneryRingStructureList";

		private const string ResCategory = "uismeltjournery";

		public static bool AbleToPerform()
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

		protected override void OnGetToForground()
		{
		}

		private void handleOnClose()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
