using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class SmeltJourneyArrayGlimpseIntent : IceUIIntent
	{
		private const string IntentKey = "UiSmeltJourneryArrayGlimpse";

		private const string ResCategory = "uismeltjournery";

		private BattleArray array;

		private bool includingBkgnd;

		public SmeltJourneyArrayGlimpseIntent(BattleArray array, bool includingBkgnd)
		{
		}

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

		private void handleOnClose()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
