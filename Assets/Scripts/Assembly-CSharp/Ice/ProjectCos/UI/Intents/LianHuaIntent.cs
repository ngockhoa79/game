using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class LianHuaIntent : IceUIIntent
	{
		private const string IntentKeyword = "LianHua";

		private const string ResCategory = "uilianhua";

		private ItemHolding[] AfterSelectData;

		public ItemHolding[] BeforeSelectData;

		public int ChooseLianHuaType { get; set; }

		public LianHuaIntent(int chooseType = -1)
		{
		}

		public override bool IsPerformable(bool showMessage)
		{
			return false;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		public void AfterSelectionCancel()
		{
		}

		public void AfterSelection(List<ItemHolding> newList, int lastSelectIndex)
		{
		}

		public void ClearCacheData()
		{
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
	}
}
