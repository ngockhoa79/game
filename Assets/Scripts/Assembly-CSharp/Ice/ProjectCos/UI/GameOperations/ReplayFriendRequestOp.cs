namespace Ice.ProjectCos.UI.GameOperations
{
	public class ReplayFriendRequestOp : Operation
	{
		public int FriendIDToAnswer { get; set; }

		public bool IsAccept { get; set; }

		public ReplayFriendRequestOp()
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
