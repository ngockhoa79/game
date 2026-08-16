using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ArrayConfirmPVPIntent : IceUIIntent
	{
		private const string IntentKey = "UIArrayConfirm";

		private const string ResCategory = "uiarrayeditor";

		private UIArena uiArena;

		private bool isTrial;

		private int challengedTimes;

		private int boughtTimes;

		public Player LeftPlayer { get; private set; }

		public Player RightPlayer { get; private set; }

		public ArrayConfirmPVPIntent(Player left, Player right, UIArena ui, bool isTrial, int challenged, int bought)
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

		private void handleStartPVPBattle()
		{
		}

		private void popUpChallengeTimesRunningOut()
		{
		}

		private void sendBuyChallengeReq(int cost)
		{
		}

		private void startPVPBattle(Player challenger)
		{
		}

		private void clickInspect(Player p)
		{
		}

		private void clickEditArray()
		{
		}

		private void startPVPBattleOp(Player challenger)
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
