using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PVPFetchBattleReportsOP : Operation
	{
		public S2CRankIngBattleReportAck BattleReports { get; private set; }

		public PVPFetchBattleReportsOP()
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
