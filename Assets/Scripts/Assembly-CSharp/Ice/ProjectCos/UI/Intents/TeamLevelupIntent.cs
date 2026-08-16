namespace Ice.ProjectCos.UI.Intents
{
	public class TeamLevelupIntent : IceUIIntent
	{
		private const string IntentKeyword = "TeamLevelup";

		private int beforeLv;

		private int afterLv;

		public TeamLevelupIntent(int _beforeLv, int _afterLv)
		{
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

		protected override void OnGetToBackgorund()
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
