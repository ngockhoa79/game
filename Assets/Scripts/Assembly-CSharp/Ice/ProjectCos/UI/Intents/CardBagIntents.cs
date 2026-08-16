using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class CardBagIntents : IceUIIntent
	{
		private const string IntentKeyword = "CardBag";

		private string defaultTabName;

		public bool _initSellMode;

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void DoInit()
		{
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

		private void OnHome()
		{
		}

		private void OnStrengthen(Hero hero)
		{
		}
	}
}
