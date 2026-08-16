using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ConvoyStageIntent : IceUIIntent
	{
		public enum ConvoyState
		{
			LevelNotEnough = 0,
			TimeNotValid = 1,
			Open = 2
		}

		private const string IntentKeyword = "ConvoyStage";

		public static ConvoyState AbleToPerform()
		{
			return default(ConvoyState);
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void DoInit()
		{
		}

		public override void DoDispose()
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void ShowStartSetupUI(int car_type, int success_rate)
		{
		}

		private void OnStartShipSuccessful(EscortTargetProto targetProto)
		{
		}

		private void OnEnterArrayEditor(EscortLobbyData data)
		{
		}

		private void OnViewPlayerInfo(Friend viewFriend)
		{
		}

		private void OnHome()
		{
		}

		private void OnReturn()
		{
		}

		public static string System_Function_Convoy_Time_Not_Valid_Final()
		{
			return null;
		}
	}
}
