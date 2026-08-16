namespace Ice.ProjectCos.UI.Intents
{
	public class TaskAchiveIntent : IceUIIntent
	{
		private const string IntentKeyword = "TaskAchive";

		public TaskAchiveIntent()
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			if (panelCollector != null)
			{
				if (!panelCollector.TryGetPanel("TaskAchive", out var panel))
				{
					panel = Util.UILoader.Load<UIPanel>("TaskAchive", "taskachive", panelCollector.transform);
					panelCollector.RegistPanel("TaskAchive", panel);
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
			UITaskAchive ui = Panel<UITaskAchive>();
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

		protected override void ClearPanelData()
		{
			base.ClearPanelData();
		}
	}
}
