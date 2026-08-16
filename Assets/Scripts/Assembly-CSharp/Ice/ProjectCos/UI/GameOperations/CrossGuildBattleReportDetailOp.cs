using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CrossGuildBattleReportDetailOp : Operation
	{
		public S2CrossGuildBattleReportDetailAck ACK;

		private int Line;

		private bool IsFirstRound;

		public CrossGuildBattleReportDetailOp(int _line, bool _firstRound)
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
