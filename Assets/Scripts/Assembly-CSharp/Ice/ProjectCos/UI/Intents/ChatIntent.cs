using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class ChatIntent : IceUIIntent
	{
		private bool mIsDebugMode;

		public C2SChatReq.TypeEnum ChatType;

		private const string IntentKeyword = "Chat";

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
