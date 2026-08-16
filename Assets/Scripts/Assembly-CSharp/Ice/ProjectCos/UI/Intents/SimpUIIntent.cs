namespace Ice.ProjectCos.UI.Intents
{
	public abstract class SimpUIIntent : IceUIIntent
	{
		protected abstract string getUIName();

		protected abstract string getUIType();

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void ClearPanelData()
		{
		}
	}
}
