namespace Ice.ProjectCos.UI.GameOperations
{
	public class NurtureRestoreOp : Operation
	{
		private int _heroIndex;

		public NurtureRestoreOp(int heroIndex)
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
