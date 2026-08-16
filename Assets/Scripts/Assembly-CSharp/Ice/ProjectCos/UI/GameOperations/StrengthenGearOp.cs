using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class StrengthenGearOp : Operation
	{
		private bool isAutoUp;

		public GearHolding OldHolding { get; private set; }

		public GearHolding NewHolding { get; private set; }

		public StrengthenGearOp(GearHolding holding, bool autoUp)
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
