using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class RequestDuplicateSupportersOp : Operation
	{
		public int DuplicationID { get; private set; }

		public RequestDuplicateSupportersOp(int duplicationID)
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

		private List<Friend> constructFriendList(List<DuplicateSupporterProto> supporters, int start)
		{
			return null;
		}

		private Friend constructFriend(int index, PlayerSummaryInfoProto info)
		{
			return null;
		}
	}
}
