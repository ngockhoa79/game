using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ItemMultiSelectIntent : IceUIIntent
	{
		private const string IntentKeyword = "ItemMultiSelector";

		private UIItemMultiSelector.ESelectType SelectType;

		private UIItemMultiSelector.EFilterType FilterType;

		private List<Hero> SelectedHeroes;

		private List<ItemHolding> SelectedHoldings;

		private int LimitCount;

		private Hero mainHero;

		private ItemHolding mainHolding;

		public Action<List<Hero>> OnHeroCart;

		public Action<List<ItemHolding>> OnItemCart;

		public Action OnCancel;

		public ItemMultiSelectIntent(UIItemMultiSelector.ESelectType selectType, List<Hero> selectedHeroes, List<ItemHolding> selectedHoldings, int limitCount = -1, Hero mainHero = null, ItemHolding mainHolding = null, UIItemMultiSelector.EFilterType filterType = UIItemMultiSelector.EFilterType.None)
		{
		}

		protected override UIPanel GetPanel(IceUIPanelCollector panelCollector)
		{
			return null;
		}

		protected override void ClearPanelData()
		{
		}

		protected override void OnGetToForground()
		{
		}

		protected override void OnGetToBackgorund()
		{
		}

		private void OnCardSelect(List<Hero> heroes)
		{
		}

		private void OnItemSelect(List<ItemHolding> holdings)
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
