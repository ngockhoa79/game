using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class SmeltJourneyArrayEditorIntent : IceUIIntent
	{
		private const string IntentKey = "UISmeltJourneryArrayEditor";

		private const string ResCategory = "uismeltjournery";

		private bool isManito;

		private int _superIndex;

		public SmeltJourneyArrayEditorIntent(int superIndex = -1)
		{
		}

		public static bool AbleToPerform()
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

		protected override void OnGetToForground()
		{
		}

		private void handleEditArray()
		{
		}

		private void commitArray()
		{
		}

		private void handleStart()
		{
		}

		private List<int> getSelectedContent()
		{
			return null;
		}

		private void handleOnBack()
		{
		}

		private void handleOnHome()
		{
		}

		private void handleOnEnemyArray(Player p)
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
