using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

namespace Ice.ProjectCos.UI.Intents
{
	public class SkillArmSelectorIntents : SkillMultiSelectorBaseIntent
	{
		private ESkillType SkillType;

		private SkillHolding armedSkill;

		private Skill talentSkill;

		private bool bIncludeUnload;

		public SkillArmSelectorIntents(ESkillType skillType, SkillHolding armed = null, Skill talent = null, bool includeUnload = false)
		{
		}

		protected override IEnumerable<ItemHolding> GetFilterList()
		{
			return null;
		}

		protected override void internalSetData(GameObject widget, ItemHoldingGroup itemholdingGroup, UICommonItem.EState item1State, UICommonItem.EState item2State)
		{
		}

		private void show_item_strength_tag(UICommonSkillItem ui)
		{
		}

		protected override void SetPanelSettings(UICommonMultiSelector panel)
		{
		}
	}
}
