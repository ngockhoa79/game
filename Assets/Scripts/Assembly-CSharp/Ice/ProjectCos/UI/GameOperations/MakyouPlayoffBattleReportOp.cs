using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouPlayoffBattleReportOp : Operation
	{
		public S2CCrossPersonPlayOffBattleReportAck ACK;

		protected int BattleIndex;

		public MakyouPlayoffBattleReportOp(int index)
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
