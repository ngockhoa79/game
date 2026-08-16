using System;

namespace Ice.ProjectCos.UI.Intents
{
	public class GuildRankIntent : IceUIIntent
	{
		public Action OnClose;

		private const string IntentKeyword = "GuildRank";

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		public override void DoDispose()
		{
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
