using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class LuggageSkillMaterialSelectIntents : IceUIIntent
	{
		private const string IntentKey = "SkillSelector";

		private const string ResCategory = "uiluggage";

		private ItemHolding source;

		private int slot;

		public LuggageSkillMaterialSelectIntents(ItemHolding _source, int _slot)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void ClearPanelData()
		{
		}

		protected override void SetPanelData()
		{
		}

		private void OnSelect(SkillHolding skill)
		{
		}

		private void OnReturn()
		{
		}

		private void OnHomePage()
		{
		}
	}
}
