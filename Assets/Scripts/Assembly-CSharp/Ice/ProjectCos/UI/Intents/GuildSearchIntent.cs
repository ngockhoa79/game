using System.Collections.Generic;

namespace Ice.ProjectCos.UI.Intents
{
	public class GuildSearchIntent : IceUIIntent
	{
		private const string IntentKeyword = "GuildSearch";

		private List<GuildInfo> guildList;

		private int maxCount;

		public GuildSearchIntent(List<GuildInfo> _list, int _maxCount)
		{
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

		public override void DoDispose()
		{
		}
	}
}
