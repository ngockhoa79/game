using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class StartPVEOp : Operation
	{
		private List<int> columnPositions;

		public int DuplicateID { get; private set; }

		public int chapterType { get; private set; }

		public int FriendID { get; private set; }

		public int ReplacePostion { get; private set; }

		public StartPVEOp(int duplicateID, int chapterType, int friendID = 0, int replacePostion = -1)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public StartPVEOp(int duplicateID, int chapterType, List<int> positions, int friendID)
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

		private void ApplyChange(S2CDuplicateBattleAck ack)
		{
		}
	}
}
