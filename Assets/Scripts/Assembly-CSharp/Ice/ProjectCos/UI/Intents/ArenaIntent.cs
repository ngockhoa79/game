using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class ArenaIntent : IceUIIntent
	{
		private const string IntentKey = "Arena";

		private const string ResCategory = "uiarena";

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override void SetPanelData()
		{
		}

		private void handlePopRank(GameObject btn)
		{
		}

		private void handleRedPack()
		{
		}

		private void handleRefresh()
		{
		}

		private void reqChallengersFail(object res, NetManager.CoreErrorCode err_code)
		{
		}

		private void activateArrayConfirm(Player challenger, bool isTrial, int challengedTimes, int boughtTimes)
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void tip(string t)
		{
		}
	}
}
