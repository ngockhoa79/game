using Ice.ProjectCos.Config;

namespace Ice.ProjectCos.UI.Intents
{
	public class MainNextFunctionIntent : IceUIIntent
	{
		private const string IntentKeyword = "MainNextFunction";

		private FunctionType nextFunctionType;

		public MainNextFunctionIntent(FunctionType _type)
		{
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

		public override void DoDispose()
		{
		}
	}
}
