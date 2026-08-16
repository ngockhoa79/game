namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoyBeWrestClearOp : Operation
	{
		public bool isOK;

		public ConvoyBeWrestClearOp()
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
