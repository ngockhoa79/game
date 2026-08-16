namespace Ice.ProjectCos.UI.GameOperations
{
	public class AddCardBagSlotOp : Operation
	{
		public bool isOK;

		public AddCardBagSlotOp()
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
