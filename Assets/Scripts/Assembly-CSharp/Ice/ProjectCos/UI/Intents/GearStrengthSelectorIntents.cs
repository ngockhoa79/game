using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class GearStrengthSelectorIntents : GearMultiSelectorBaseIntents
	{
		private int mFilteredGear;

		public GearStrengthSelectorIntents(int filtered = -1)
		{
		}

		protected override void SetPanelSettings(UICommonMultiSelector panel)
		{
		}

		protected override IEnumerable<ItemHolding> GetFilterList()
		{
			return null;
		}

		protected override void internalSetData(GameObject widget, ItemHoldingGroup itemholdingGroup, UICommonItem.EState item1State, UICommonItem.EState item2State)
		{
		}

		private void show_gear_strength_tag(UICommonGearItem ui)
		{
		}
	}
}
