namespace Ice.ProjectCos.UI.GameOperations
{
	public class AddEquipBagSlotOp : Operation
	{
		public bool isOK;

		public AddEquipBagSlotOp()
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
