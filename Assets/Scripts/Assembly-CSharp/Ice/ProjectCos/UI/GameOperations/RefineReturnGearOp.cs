using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RefineReturnGearOp : Operation
	{
		public GearHolding OldHolding { get; private set; }

		public GearHolding NewHolding { get; private set; }

		public RefineReturnGearOp(GearHolding holding)
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
