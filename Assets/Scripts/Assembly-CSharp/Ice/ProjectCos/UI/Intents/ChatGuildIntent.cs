using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class ChatGuildIntent : IceUIIntent
	{
		public Action OnClose;

		private bool mIsDebugMode;

		public C2SChatReq.TypeEnum ChatType;

		private const string IntentKeyword = "ChatGuild";

		public override bool IsPerformable(bool showMessage)
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
	}
}
