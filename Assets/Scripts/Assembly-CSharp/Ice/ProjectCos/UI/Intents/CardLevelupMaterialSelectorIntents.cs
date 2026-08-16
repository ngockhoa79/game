using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class CardLevelupMaterialSelectorIntents : CardMultiSelectorBaseIntents
	{
		public Hero MainHero;

		private List<Hero> selectedList;

		private int max;

		public CardLevelupMaterialSelectorIntents(Hero mainHero, List<Hero> selectedList, int max = 1)
		{
		}

		public override IEnumerable<ItemHolding> GetFilterList()
		{
			return null;
		}

		protected override void SetPanelData()
		{
		}

		protected override void internalSetData(GameObject widget, ItemHoldingGroup itemholdingGroup, UICommonItem.EState item1State, UICommonItem.EState item2State)
		{
		}

		protected override void SetPanelSettings(UICommonMultiSelector panel)
		{
		}
	}
}
