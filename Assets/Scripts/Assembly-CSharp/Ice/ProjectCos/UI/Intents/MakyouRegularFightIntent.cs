using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class MakyouRegularFightIntent : IceUIIntent
	{
		private const string IntentKey = "MakyouRegularFight";

		private const string ResPanelKey = "UIArrayConfirm";

		private const string ResCategory = "uiarrayeditor";

		private string OpponentID;

		public Player LeftPlayer { get; private set; }

		public Player RightPlayer { get; private set; }

		public MakyouRegularFightIntent(Player left, Player right, string rightID)
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
