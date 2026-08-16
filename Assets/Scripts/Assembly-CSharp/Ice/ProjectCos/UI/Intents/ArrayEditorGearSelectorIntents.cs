using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class ArrayEditorGearSelectorIntents : GearMultiSelectorBaseIntents
	{
		private GearHolding _selfHolding;

		private EGearSlot _selfSlot;

		public ArrayEditorGearSelectorIntents(EGearSlot slot, GearHolding gearHolding)
		{
		}

		protected override void SetPanelSettings(UICommonMultiSelector panel)
		{
		}

		protected override IEnumerable<ItemHolding> GetFilterList()
		{
			return null;
		}
	}
}
