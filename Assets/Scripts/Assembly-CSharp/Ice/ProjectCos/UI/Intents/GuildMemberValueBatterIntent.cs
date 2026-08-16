using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class GuildMemberValueBatterIntent : IceUIIntent
	{
		private const string IntentKeyword = "GuildMemberValueBatter";

		private S2CCrossGuildPlayerRankingAck ack;

		public GuildMemberValueBatterIntent(S2CCrossGuildPlayerRankingAck data)
		{
		}

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
