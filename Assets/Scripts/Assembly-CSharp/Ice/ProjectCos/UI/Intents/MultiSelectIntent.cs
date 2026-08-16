using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class MultiSelectIntent : IceUIIntent
	{
		private const string IntentKeyword = "UIMultiSelector";

		public Action<List<ItemHolding>> OnItemCart;

		public Action OnCancel;

		public MyCart Cart { get; set; }

		public TabEnum OpenTab { get; set; }

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

		private void OnItemSelectComplete(List<ItemHolding> holdings)
		{
		}

		private void OnHome()
		{
		}

		private void OnReturn()
		{
		}
	}
}
