using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class EquipGearOp : Operation
	{
		public Hero Card { get; private set; }

		public GearHolding Holding { get; private set; }

		public EquipGearOp(Hero card, GearHolding holding)
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
