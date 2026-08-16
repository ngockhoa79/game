using System;
using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.Intents
{
	public class RedPackIntent : IceUIIntent
	{
		private const string IntentKey = "ArenaRedPackDisplayer";

		private const string ResCategory = "uiarena";

		private C2SRedPackListReq.TypeEnum defaultTab;

		public RedPackIntent(C2SRedPackListReq.TypeEnum tab)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		private void req(C2SRedPackListReq.TypeEnum t, Action<S2CRedPackListAck> callback)
		{
		}

		private void revoke()
		{
		}

		protected override void SetPanelData()
		{
		}

		public void SendRequest()
		{
		}

		private void addAndDisplay(S2CRedPackListAck ack, List<S2CRedPackListAck> r)
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
