using System;

namespace Ice.ProjectCos.UI.Intents
{
	public abstract class IceUIIntent : Intent
	{
		protected override void SetPanelData()
		{
			IceUIBase iceUI = Panel<IceUIBase>();
			if (iceUI != null)
			{
				iceUI.Prepare();
			}
		}

		protected override void EnterScreen(Action callback, bool playEffects)
		{
			IceUIBase iceUI = Panel<IceUIBase>();
			if (iceUI != null)
			{
				iceUI.EnterScreen(callback, playEffects, true);
			}
			else
			{
				callback?.Invoke();
			}
		}

		protected override void DisposeScreen(Action callback, bool playEffects)
		{
			IceUIBase iceUI = Panel<IceUIBase>();
			if (iceUI != null)
			{
				iceUI.ExitScreen(callback, playEffects, true);
			}
			else
			{
				callback?.Invoke();
			}
		}

		protected override void ClearPanelData()
		{
			IceUIBase iceUI = Panel<IceUIBase>();
			if (iceUI != null)
			{
				iceUI.ExitScreen(null, true, true);
			}
		}

		protected override bool EnforceAssistantOn()
		{
			return false;
		}

		public override bool IsPerformable(bool showMessage)
		{
			return true;
		}

		protected IceUIIntent() : base()
		{
		}
	}
}
