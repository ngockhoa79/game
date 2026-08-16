namespace Ice.ProjectCos.UI.GameOperations
{
	public class PromoteCarOp : Operation
	{
		public int CardID { get; private set; }

		public int SuccessRate { get; private set; }

		public PromoteCarOp()
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
