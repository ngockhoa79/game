using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public abstract class CardMultiSelectorBaseIntents : IceUIIntent
	{
		private const string IntentKeyword = "CardMultiSelector";

		public Action<List<ItemHolding>> E_OnSelect;

		public Action E_OnUnload;

		public Action E_OnCustomReturn;

		public Action E_OnCustomHome;

		public abstract IEnumerable<ItemHolding> GetFilterList();

		protected abstract void SetPanelSettings(UICommonMultiSelector panel);

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void DoInit()
		{
		}

		public override void DoDispose()
		{
		}

		protected override void SetPanelData()
		{
		}

		protected override void ClearPanelData()
		{
		}

		protected virtual GameObject internalCreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		private GameObject internalCreateSperator(Transform widgetsHolder)
		{
			return null;
		}

		protected virtual void internalSetData(GameObject widget, ItemHoldingGroup itemholdingGroup, UICommonItem.EState item1State, UICommonItem.EState item2State)
		{
		}

		private void internalClearData(GameObject widget)
		{
		}

		private void internalWidgetStateChange(GameObject widget, UICommonItem.EState item1State, UICommonItem.EState item2State)
		{
		}

		private IEnumerable<ItemHolding> internalGetFilterList()
		{
			return null;
		}
	}
}
