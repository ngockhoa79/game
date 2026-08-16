using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class UISmeltJourneyBattleReportIntent : IceUIIntent
	{
		private const string IntentKey = "UISmeltJourneryBattleReport";

		private const string ResCategory = "uismeltjournery";

		private C2STrialBattleReportAck _ack;

		public UISmeltJourneyBattleReportIntent(C2STrialBattleReportAck ack = null)
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

		private void handleOnHome()
		{
		}

		private void handleOnBack()
		{
		}

		private void handleOnRank()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
