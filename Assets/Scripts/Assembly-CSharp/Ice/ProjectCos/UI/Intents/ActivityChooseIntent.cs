namespace Ice.ProjectCos.UI.Intents
{
	public class ActivityChooseIntent : IceUIIntent
	{
		private const string IntentKeyword = "ActivityChoose";

		private bool mPlayAnimation;

		public int ChoosedChapterID { get; set; }

		public int ChoosedLevelID { get; set; }

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

		protected override void OnGetToBackgorund()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
