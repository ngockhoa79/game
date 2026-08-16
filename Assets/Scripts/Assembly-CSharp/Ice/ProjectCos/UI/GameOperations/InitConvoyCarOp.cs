namespace Ice.ProjectCos.UI.GameOperations
{
	public class InitConvoyCarOp : Operation
	{
		public int CarID { get; private set; }

		public int SuccessRate { get; private set; }

		public InitConvoyCarOp()
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
