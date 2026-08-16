using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class FragmentArrayConfirmIntent : IceUIIntent
	{
		private const string IntentKey = "UIArrayConfirm";

		private const string ResCategory = "uiarrayeditor";

		public BattleArray LeftArray { get; private set; }

		public BattleArray RightArray { get; private set; }

		public SkillFragment _SkillFragment { get; private set; }

		public ulong _TargetPlayerId { get; private set; }

		public FragmentArrayConfirmIntent(BattleArray leftArray, BattleArray rightArray, SkillFragment skillFragment, ulong playerId)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void clickInspect(Player p)
		{
		}

		private void handleClickCard(Hero card)
		{
		}

		private void clickEditArray()
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void handleStartPVXBattle()
		{
		}

		private void startPVXBattle(BattleArray challenger)
		{
		}

		private void startPVXBattleOp(BattleArray challenger)
		{
		}

		private void clickReturn()
		{
		}

		private void clickHomePage()
		{
		}

		private void clickViewSwitch()
		{
		}
	}
}
