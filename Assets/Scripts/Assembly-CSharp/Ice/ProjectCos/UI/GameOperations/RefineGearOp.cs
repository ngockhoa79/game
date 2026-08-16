using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RefineGearOp : Operation
	{
		public EquipmentItemProto.LockCodeEnum LockType { get; private set; }

		public GearHolding OldHolding { get; private set; }

		public GearHolding NewHolding { get; private set; }

		public RefineGearOp(GearHolding holding, EquipmentItemProto.LockCodeEnum type)
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
