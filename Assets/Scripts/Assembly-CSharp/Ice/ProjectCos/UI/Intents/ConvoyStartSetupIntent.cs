using System;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class ConvoyStartSetupIntent : IceUIIntent
	{
		private const string IntentKeyword = "ConvoyStartSetup";

		private int shipID;

		private int successRate;

		public Action<EscortTargetProto> OnStartShipSuccess;

		public ConvoyStartSetupIntent(int shipID, int successRate)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void OnGetToForground()
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		protected override void ClearPanelData()
		{
		}

		private void OnReturn()
		{
		}

		private void OnSelectGuard()
		{
		}

		private void OnStartSuccess(EscortTargetProto targetProto)
		{
		}

		private void OnShipUpdated(int shipType, int ShipRate)
		{
		}
	}
}
