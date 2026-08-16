using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FriendQieCuoOp : Operation
	{
		public S2CFriendBattleAck ACK;

		private Friend mFriend;

		private BattleReport mRsBattleReport;

		private int mFrindPoint;

		public FriendQieCuoOp(Friend friend)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public BattleReport GetResultBattleReport()
		{
			return null;
		}

		public int GetFriendPointGain()
		{
			return 0;
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
