namespace Ice.ProjectCos.UI.Intents
{
	public class ArrayConfirmGlimpseIntent : IceUIIntent
	{
		private const string IntentKey = "UIArrayConfirmGlimpse";

		private const string ResCategory = "uiarrayeditor";

		private BattleArrayMisc array;

		private bool includingBkgnd;

		private bool redFrame;

		public ArrayConfirmGlimpseIntent(BattleArrayMisc array, bool includingBkgnd, bool redFrame)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		private void handleOnClose()
		{
		}

		protected override void ClearPanelData()
		{
		}
	}
}
