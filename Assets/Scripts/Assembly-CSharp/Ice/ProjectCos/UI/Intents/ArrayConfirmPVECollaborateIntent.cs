using System;
using System.Collections.Generic;

namespace Ice.ProjectCos.UI.Intents
{
	public class ArrayConfirmPVECollaborateIntent : IceUIIntent
	{
		private const string IntentKey = "UICollaborateArrayConfirm";

		private const string ResCategory = "uiarrayeditor";

		private List<ColumnInfo> mine;

		private List<ColumnInfo> supporter;

		private BattleArrayMisc machine;

		public Action<List<int>> OnStartChallenge;

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		public ArrayConfirmPVECollaborateIntent(List<ColumnInfo> mine, List<ColumnInfo> supporter, BattleArrayMisc machine)
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void SetPanelData()
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

		private void clickGlimpse(BattleArrayMisc array)
		{
		}
	}
}
