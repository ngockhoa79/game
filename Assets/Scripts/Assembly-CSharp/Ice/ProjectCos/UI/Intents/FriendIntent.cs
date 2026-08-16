using Ice.ProjectCos.UI.Util;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class FriendIntent : IceUIIntent
	{
		private const string IntentKeyword = "Friend";

		public int OpenPanel { get; set; }

		public override bool IsPerformable(bool showMessage)
		{
			return true;
		}

		public FriendIntent() : base()
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			if (panelCollector != null)
			{
				UIPanel panel;
				if (panelCollector.TryGetPanel("Friend", out panel))
				{
					return panel;
				}
				panel = UILoader.Load<UIPanel>("UIFriend", "friend", panelCollector.transform);
				if (panel != null)
				{
					panelCollector.RegistPanel("Friend", panel);
				}
				return panel;
			}
			return null;
		}

		protected override void SetPanelData()
		{
			base.SetPanelData();
		}

		protected override void ClearPanelData()
		{
			base.ClearPanelData();
		}
	}
}
