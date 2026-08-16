using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FriendAddRequestOp : Operation
	{
		public List<ulong> mIdList;

		public FriendAddRequestOp(ulong friendID)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public FriendAddRequestOp(Friend f)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public FriendAddRequestOp(List<Friend> listF)
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
