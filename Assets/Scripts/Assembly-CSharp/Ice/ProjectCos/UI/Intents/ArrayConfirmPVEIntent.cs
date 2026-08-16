using System;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ArrayConfirmPVEIntent : IceUIIntent
	{
		private const string IntentKey = "UIArrayConfirm";

		private const string ResCategory = "uiarrayeditor";

		private static BattleArrayMisc LeftArray;

		public Action OnStartChallenge;

		private static Hero substituteCard;

		public BattleArrayMisc RightArray { get; private set; }

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		public static BattleArray GetActiveArray()
		{
			return null;
		}

		public static void UpdateActiveArray(BattleArray array)
		{
		}

		public static void UpdateSubstitution(Hero card)
		{
		}

		public ArrayConfirmPVEIntent(BattleArrayMisc leftArray, BattleArrayMisc rightArray)
		{
		}

		protected override void OnGetToForground()
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

		private void clickReturn()
		{
		}

		private void clickHomePage()
		{
		}

		private void clickSwitchSupporter()
		{
		}

		private void clickEditArray()
		{
		}

		private Hero getCheerHero()
		{
			return null;
		}
	}
}
