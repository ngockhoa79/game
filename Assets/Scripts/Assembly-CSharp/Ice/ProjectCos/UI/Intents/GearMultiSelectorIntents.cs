using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.Intents
{
	public class GearMultiSelectorIntents : GearMultiSelectorBaseIntents
	{
		protected override IEnumerable<ItemHolding> GetFilterList()
		{
			return null;
		}

		protected override void OnGetToForground()
		{
		}

		protected override void SetPanelSettings(UICommonMultiSelector panel)
		{
		}
	}
}
