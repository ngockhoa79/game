namespace Ice.ProjectCos.UI.GameOperations
{
	public class RobberyHelpFriendOp : Operation
	{
		private int _friendRequestIndex;

		private int _skillFragmentId;

		public RobberyHelpFriendOp(int friendRequestIndex, int skillFragmentId)
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
