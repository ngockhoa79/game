using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ConvoyLootArrayIntent : IceUIIntent
	{
		private const string IntentKey = "ConvoyLootArray";

		private const string ResPanelKey = "UIArrayConfirm";

		private const string ResCategory = "uiarrayeditor";

		public Player LeftPlayer { get; private set; }

		public Player RightPlayer { get; private set; }

		public Player RightPlayerGuard { get; private set; }

		public int ShipType { get; private set; }

		public int shipID { get; private set; }

		public ConvoyLootArrayIntent(Player left, Player right, Player guard, int shipType, int shipID)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
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

		private void handleOnClickCard(Hero card)
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void commitArray()
		{
		}

		private void handleStartLoot()
		{
		}

		private void clickInspect(Player p)
		{
		}

		private void clickEditArray()
		{
		}

		private void pop(string msg)
		{
		}

		private void clickReturn()
		{
		}

		private void clickHomePage()
		{
		}
	}
}
