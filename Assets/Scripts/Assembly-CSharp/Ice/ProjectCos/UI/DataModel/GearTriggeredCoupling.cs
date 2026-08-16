using Ice.ProjectCos.Config;
using Ice.ProjectCos.UI.Util;

namespace Ice.ProjectCos.UI.DataModel
{
	public class GearTriggeredCoupling : AbstractCoupling
	{
		public FixedList<int> TriggerGearIDs { get; private set; }

		public override bool IsTriggered(Hero hero)
		{
			return false;
		}

		protected override bool FromTemplate(BondTemplateExt template)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
