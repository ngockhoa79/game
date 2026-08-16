namespace Ice.ProjectCos.UI.Intents
{
	public class VipIntent : IceUIIntent
	{
		private const string IntentKeyword = "VipDetail";

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

		public override void DoDispose()
		{
		}
	}
}
