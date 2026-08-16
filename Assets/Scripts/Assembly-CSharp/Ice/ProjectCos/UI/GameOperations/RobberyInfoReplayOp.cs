namespace Ice.ProjectCos.UI.GameOperations
{
	public class RobberyInfoReplayOp : Operation
	{
		private int _id;

		public RobberyInfoReplayOp(int _reportId)
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
