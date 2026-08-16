using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class LuggageSelectSkillIntents : IceUIIntent
	{
		private const string IntentKey = "SkillSelector";

		private const string ResCategory = "uiluggage";

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
