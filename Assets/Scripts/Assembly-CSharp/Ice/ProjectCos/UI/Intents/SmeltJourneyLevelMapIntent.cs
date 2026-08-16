using System;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class SmeltJourneyLevelMapIntent : IceUIIntent
	{
		private const string IntentKey = "SmeltJourneryMap";

		private const string ResCategory = "uismeltjournery";

		private Action onStageObtained;

		public override bool IsPerformable(bool showMessage)
		{
			return false;
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

		protected override void ClearPanelData()
		{
		}

		private void handleOnHome()
		{
		}

		private void handleOnBack()
		{
		}

		private void handleOnHelp(Transform parent)
		{
		}

		private void handleOnRank()
		{
		}

		private void handleOnBattleReport()
		{
		}

		private void handleOnExchange()
		{
		}

		private void handleObtain(int superIndex = -1)
		{
		}

		private void handleKick(int superIndex)
		{
		}
	}
}
