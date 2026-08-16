namespace Ice.ProjectCos.UI.Intents
{
	public class SkillBagIntents : IceUIIntent
	{
		private const string IntentKeyword = "SkillBag";

		public bool InitSellMode;

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void DoInit()
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void OnHome()
		{
		}
	}
}
