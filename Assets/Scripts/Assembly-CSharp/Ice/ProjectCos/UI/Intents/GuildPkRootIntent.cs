using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class GuildPkRootIntent : IceUIIntent
	{
		private const string IntentKeyword = "GuildPkRoot";

		private CrossGuildFormationProto formData;

		private CrossGuildBattleOverPlayerRewardProto resultData;

		public GuildPkRootIntent(CrossGuildFormationProto _proto, CrossGuildBattleOverPlayerRewardProto _resultProto)
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
