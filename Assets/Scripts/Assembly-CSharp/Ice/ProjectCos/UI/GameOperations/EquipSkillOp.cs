using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class EquipSkillOp : Operation
	{
		public Hero Card { get; private set; }

		public int SlotIndex { get; private set; }

		public SkillHolding Holding { get; private set; }

		public EquipSkillOp(Hero card, int slot, SkillHolding holding)
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
