namespace Ice.ProjectCos.UI.GameOperations
{
	public class RobberyHelpRequestOp : Operation
	{
		private ulong _friendId;

		private int _reportId;

		public RobberyHelpRequestOp(ulong friendId, int reportId)
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
