using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class SkillUpgraderSelectorIntent : SkillMultiSelectorBaseIntent
	{
		protected override IEnumerable<ItemHolding> GetFilterList()
		{
			return null;
		}

		protected override void SetPanelSettings(UICommonMultiSelector panel)
		{
		}

		protected override void internalSetData(GameObject widget, ItemHoldingGroup itemholdingGroup, UICommonItem.EState item1State, UICommonItem.EState item2State)
		{
		}

		private void show_item_strength_tag(UICommonSkillItem ui)
		{
		}
	}
}
