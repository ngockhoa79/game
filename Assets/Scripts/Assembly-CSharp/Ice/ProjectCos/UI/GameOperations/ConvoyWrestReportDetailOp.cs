using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ConvoyWrestReportDetailOp : Operation
	{
		public int ReportId { get; private set; }

		public bool isOK { get; private set; }

		public BattleReportProto BattleReport { get; private set; }

		public ConvoyWrestReportDetailOp(int reportId)
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
