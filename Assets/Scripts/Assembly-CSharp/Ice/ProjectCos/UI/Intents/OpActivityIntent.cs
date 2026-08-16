namespace Ice.ProjectCos.UI.Intents
{
	public class OpActivityIntent : IceUIIntent
	{
		private const string IntentKeyword = "OpActivity";

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}

		protected override void OnGetToForground()
		{
		}
	}
}
