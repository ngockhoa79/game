using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class SkillPopupIntent : IceUIIntent
	{
		private const string IntentKeyword = "SkillPopupIntent";

		public Hero Card { get; private set; }

		public SkillHolding Holding { get; private set; }

		public int Slot { get; private set; }

		public SkillPopupIntent(Hero card, SkillHolding holding, int slot = -1)
		{
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
	}
}
