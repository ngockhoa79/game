namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoyCourageOp : Operation
	{
		public bool isOK;

		public int CourageValue { get; private set; }

		public int CourageCount { get; private set; }

		public ConvoyCourageOp()
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
