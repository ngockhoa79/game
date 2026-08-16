namespace Ice.ProjectCos.UI.GameOperations
{
	public class RobberyRevengeOp : Operation
	{
		private int _id;

		private int _skillFragmentId;

		public RobberyRevengeOp(int reportId, int skillFragmentId)
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
