using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CrossGuidPickBattleOverRewardOp : Operation
	{
		public S2CCrossGuidPickBattleOverRewardAck ACK;

		public CrossGuidPickBattleOverRewardOp()
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
