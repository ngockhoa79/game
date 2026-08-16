using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FriendLeaveMsgOp : Operation
	{
		private Friend mFriendSendTo;

		private string mMsg;

		private int id;

		public FriendLeaveMsgOp(Friend friendSendTo, string msg)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public FriendLeaveMsgOp(int id, string msg)
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
