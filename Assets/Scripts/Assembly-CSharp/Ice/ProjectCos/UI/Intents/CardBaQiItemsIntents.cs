using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class CardBaQiItemsIntents : IceUIIntent
	{
		private int startIndex;

		public Hero hero;

		private const string IntentKeyword = "CardBaQiItemShow";

		public CardBaQiItemsIntents()
		{
		}

		public CardBaQiItemsIntents(int startIndex)
		{
		}

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

		protected override void ClearPanelData()
		{
		}

		public override void DoDispose()
		{
		}
	}
}
