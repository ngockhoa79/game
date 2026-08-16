using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class SelectSkillIntent : IceUIIntent
	{
		private const string IntentKey = "SkillSelector";

		private const string ResCategory = "uiluggage";

		public Hero Card { get; private set; }

		public int SkillSlot { get; private set; }

		public SelectSkillIntent(Hero card, int skillSlot)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void commit(SkillHolding skill, int SkillSlot)
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
