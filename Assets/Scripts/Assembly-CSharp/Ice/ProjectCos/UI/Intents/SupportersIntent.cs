using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class SupportersIntent : IceUIIntent
	{
		private const string IntentKey = "ArraySupporters";

		private const string ResCategory = "uiarrayeditor";

		private static int duplicationId;

		private static int chapterType;

		private static GamePlayManner manner;

		private bool onlyReplaceCard;

		private static Hero toBeReplacedHero;

		private bool isArrayFull;

		private int friendID;

		private int replacePosition;

		private int SubstitutionPostion;

		private Hero Substitution;

		private ArrayConfirmPVEIntent acpvei;

		private BattleArray duplicateSubmit;

		public SupportersIntent(Hero toBeReplaced)
		{
		}

		public SupportersIntent(int d, int ct, GamePlayManner m)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void handleOnHome()
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void handleBackClicked()
		{
		}

		private void handleSkipClicked()
		{
		}

		private BattleArrayMisc createMachineArray()
		{
			return null;
		}

		private int getFormationID()
		{
			return 0;
		}

		private BattleArrayMisc patchMyArrayWithSupporter(Player supporter)
		{
			return null;
		}

		private void enterWithEmptyFilter(BattleArrayMisc leftArray)
		{
		}

		private void handleOnChosen(Player supporter)
		{
		}

		private void replaceOneSupporter(Player supporter)
		{
		}

		private void updateAndRevoke(BattleArrayMisc leftArray, BattleArrayMisc machineArray)
		{
		}

		private void updateAndRevoke(Player mine, Player supporter, BattleArrayMisc machine)
		{
		}

		private List<ColumnInfo> createColumns(Player p)
		{
			return null;
		}

		private ColumnInfo createColumn(BattleArray array, int columnIndex, Player p, int src)
		{
			return null;
		}

		private ColumnInfo.Relation relation(Player p)
		{
			return default(ColumnInfo.Relation);
		}

		private BattleArray insertHeroIntoFirstAvailable(BattleArray array, Hero hero)
		{
			return null;
		}

		private BattleArray swapAssistant2SpecificPosition(BattleArray array)
		{
			return null;
		}

		private void startPVE(BattleArray leftArray)
		{
		}

		private void startPVE(BattleArray mine, List<int> positions, int friendID)
		{
		}

		private BattleArray arrayHoming(BattleArray array)
		{
			return null;
		}

		private void startPVEResponse(object response, BattleArray ba)
		{
		}

		private void deferredRevokeTo(int frames, Action done)
		{
		}

		private void cleanSubstitution()
		{
		}

		private void markForGuidance()
		{
		}

		private void tip(string tip)
		{
		}
	}
}
