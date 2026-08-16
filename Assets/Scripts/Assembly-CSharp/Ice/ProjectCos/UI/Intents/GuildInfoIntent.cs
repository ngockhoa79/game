namespace Ice.ProjectCos.UI.Intents
{
	public class GuildInfoIntent : IceUIIntent
	{
		private const string IntentKeyword = "GuildInfo";

		private GuildInfo guildInfo;

		private int enterTab;

		public GuildInfoIntent(GuildInfo _info)
		{
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

		public void SetData(int _enterTab)
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
