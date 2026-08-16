namespace Ice.ProjectCos.UI.Intents
{
	public class MakyouChangeIntent : IceUIIntent
	{
		private const string IntentKeyword = "UIMakyouChangPopup";

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

		protected override void ClearPanelData()
		{
		}

		public override void DoDispose()
		{
		}
	}
}
