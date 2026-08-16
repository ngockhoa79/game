using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class CardNurtureSelectorIntents : CardMultiSelectorBaseIntents
	{
		public Hero MainHero;

		public CardNurtureSelectorIntents(Hero mainHero)
		{
		}

		public override IEnumerable<ItemHolding> GetFilterList()
		{
			return null;
		}

		protected override void internalSetData(GameObject widget, ItemHoldingGroup itemholdingGroup, UICommonItem.EState item1State, UICommonItem.EState item2State)
		{
		}

		protected override void SetPanelSettings(UICommonMultiSelector panel)
		{
		}
	}
}
