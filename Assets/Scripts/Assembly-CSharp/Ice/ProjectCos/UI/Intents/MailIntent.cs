namespace Ice.ProjectCos.UI.Intents
{
	public class MailIntent : IceUIIntent
	{
		private const string IntentKeyword = "Mail";

		public MailIntent()
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			if (panelCollector != null)
			{
				if (!panelCollector.TryGetPanel("Mail", out var panel))
				{
					panel = Util.UILoader.Load<UIPanel>("Mail", "uimail", panelCollector.transform);
					panelCollector.RegistPanel("Mail", panel);
				}
				return panel;
			}
			return null;
		}

		protected override void SetPanelData()
		{
			base.SetPanelData();
			UIMail ui = Panel<UIMail>();
			if (ui != null)
			{
				if (ui.eventOutBack != null)
				{
					ui.eventOutBack.onClick = delegate
					{
						IntentStack.RevokeCurrentIntent(null);
					};
				}
				if (ui.eventOutMain != null)
				{
					ui.eventOutMain.onClick = delegate
					{
						IntentStack.RevokeToBottomIntent(null);
					};
				}
			}
		}

		protected override void OnGetToForground()
		{
			base.OnGetToForground();
		}

		protected override void OnGetToBackgorund()
		{
			base.OnGetToBackgorund();
		}

		protected override void ClearPanelData()
		{
			base.ClearPanelData();
		}
	}
}
