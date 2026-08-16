namespace Ice.ProjectCos.UI.Intents
{
	public class MakyouRootIntent : IceUIIntent
	{
		private const string IntentKeyword = "MakyouRoot";

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

		protected override void OnGetToForground()
		{
		}

		public void SetData(int _enterTab)
		{
		}

		protected override void ClearPanelData()
		{
		}

		public override void DoDispose()
		{
		}

		private void RequestMakyouData()
		{
		}

		private void OnHome()
		{
		}

		private void OnBack()
		{
		}

		private void OnRegularPageButtonFight()
		{
		}

		private void OnRegularPageRanklist()
		{
		}

		private void OnRegularPageShop()
		{
		}

		private void OnPlayoffsPageButtonArray()
		{
		}

		private void OnPlayoffsPageButtonSupportRanklist()
		{
		}
	}
}
