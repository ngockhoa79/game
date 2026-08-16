using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ForgeGearOp : Operation
	{
		public ItemHolding Formula { get; private set; }

		public GearHolding ForgedGear { get; private set; }

		public ItemHolding UsedFragments { get; private set; }

		public static int GetFragmentCount(ItemHolding formulaHolding)
		{
			return 0;
		}

		public static int GetFragmentRequirement(ItemHolding formulaHolding)
		{
			return 0;
		}

		public ForgeGearOp(ItemHolding holding)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public override object BuildRequest()
		{
			return null;
		}

		protected override void ApplyChanges(object response)
		{
		}
	}
}
