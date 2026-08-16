using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class MailContentIntent : IceUIIntent
	{
		private const string IntentKeyword = "MailContent";

		public MailItemInfo MailItem { get; set; }

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
