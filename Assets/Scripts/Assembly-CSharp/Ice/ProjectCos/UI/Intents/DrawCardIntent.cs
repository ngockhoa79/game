namespace Ice.ProjectCos.UI.Intents
{
	public class DrawCardIntent : IceUIIntent
	{
		private const string IntentKeyword = "UICardShopFrame";

		public int SubPanelToOpne;

		public DrawCardIntent(int subPanelToOpne = 0)
		{
			this.SubPanelToOpne = subPanelToOpne;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			if (panelCollector != null)
			{
				if (!panelCollector.TryGetPanel("UICardShopFrame", out var panel))
				{
					panel = Util.UILoader.Load<UIPanel>("UICardShopFrame", "drawcard", panelCollector.transform);
					panelCollector.RegistPanel("UICardShopFrame", panel);
				}
				return panel;
			}
			return null;
		}

		public override bool IsPerformable(bool showMessage)
		{
			return true;
		}

		protected override void SetPanelData()
		{
			base.SetPanelData();
			UICardShopFrame ui = Panel<UICardShopFrame>();
			if (ui != null)
			{
				ui.SubPanelToOpen = SubPanelToOpne;
				if (ui.EventBack != null)
				{
					ui.EventBack.onClick = delegate
					{
						IntentStack.RevokeCurrentIntent(null);
					};
				}
				if (ui.EventMain != null)
				{
					ui.EventMain.onClick = delegate
					{
						IntentStack.RevokeToBottomIntent(null);
					};
				}
			}
		}

		protected override void ClearPanelData()
		{
			base.ClearPanelData();
			UICardShopFrame ui = Panel<UICardShopFrame>();
			if (ui != null)
			{
				if (ui.EventBack != null)
				{
					ui.EventBack.onClick = null;
				}
				if (ui.EventMain != null)
				{
					ui.EventMain.onClick = null;
				}
			}
		}

		protected override void OnGetToForground()
		{
			base.OnGetToForground();
			UICardShopFrame ui = Panel<UICardShopFrame>();
			if (ui != null)
			{
				ui.OnGotoForeground();
			}
		}

		protected override void OnGetToBackgorund()
		{
			base.OnGetToBackgorund();
			UICardShopFrame ui = Panel<UICardShopFrame>();
			if (ui != null)
			{
				ui.OnGotoBackground();
			}
		}
	}
}
