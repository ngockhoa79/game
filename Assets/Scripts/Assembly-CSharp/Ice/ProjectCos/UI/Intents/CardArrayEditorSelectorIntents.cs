using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class CardArrayEditorSelectorIntents : CardMultiSelectorBaseIntents
	{
		public Hero MainHero;

		public CardArrayEditorSelectorIntents(Hero mainHero = null)
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

		private void show_item_strength_tag(UICommonCardItem ui)
		{
		}

		private bool CheckHaveCard(Hero hr)
		{
			return false;
		}

		private bool canArray(Hero hero)
		{
			return false;
		}

		private bool isDuplicate(Hero hero)
		{
			return false;
		}

		private bool isInArray(Hero h)
		{
			return false;
		}
	}
}
