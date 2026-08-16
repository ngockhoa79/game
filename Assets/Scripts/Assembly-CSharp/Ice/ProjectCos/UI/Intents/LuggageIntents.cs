using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Util;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class LuggageIntents : IceUIIntent
	{
		public enum ETab
		{
			Gear = 0,
			Skill = 1,
			Item = 2,
			All = 3,
			_NUM = 4
		}

		private ETab etab;

		private const string IntentKeyword = "Luggage";

		public LuggageIntents(ETab etab) : base()
		{
			this.etab = etab;
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			if (panelCollector != null)
			{
				UIPanel panel;
				if (panelCollector.TryGetPanel("Luggage", out panel))
				{
					return panel;
				}
				panel = UILoader.Load<UIPanel>("Luggage", "luggage", panelCollector.transform);
				if (panel != null)
				{
					panelCollector.RegistPanel("Luggage", panel);
				}
				return panel;
			}
			return null;
		}

		protected override void SetPanelData()
		{
			base.SetPanelData();
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

		private void onList(IceUIReusableList<ItemHolding> list, UILuggage.FilterState state)
		{
		}

		private void add(IceUIReusableList<ItemHolding> widget, MonintoredList<ItemHolding> data, UILuggage.FilterState state)
		{
		}

		public static bool IsAcceptable(UILuggage.FilterState state, ItemHolding holding)
		{
			return false;
		}

		private new bool IsPresent(ItemHolding holding)
		{
			return false;
		}

		private void forgeGear(ItemHolding holding)
		{
		}
	}
}
