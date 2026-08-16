using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PVPBattleReportDetailOperation : Operation
	{
		private int id;

		public S2CRankIngBattleReportDetailAck ACK;

		public PVPBattleReportDetailOperation(int id)
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
