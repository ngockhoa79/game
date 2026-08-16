using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FriendBattleDetailOp : Operation
	{
		public S2CFriendBattleReportDetailAck ACK;

		private BattleReport mRsBattleReport;

		private int mBattleID;

		public FriendBattleDetailOp(int battleID)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public BattleReport GetResultBattleReport()
		{
			return null;
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
