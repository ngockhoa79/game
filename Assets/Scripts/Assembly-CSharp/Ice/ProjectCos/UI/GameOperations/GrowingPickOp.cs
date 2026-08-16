namespace Ice.ProjectCos.UI.GameOperations
{
	public class GrowingPickOp : Operation
	{
		private int _index;

		public GrowingPickOp(int index)
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
