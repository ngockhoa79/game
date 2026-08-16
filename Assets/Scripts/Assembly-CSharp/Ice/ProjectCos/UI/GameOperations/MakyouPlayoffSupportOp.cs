using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouPlayoffSupportOp : Operation
	{
		public S2CCrossPersonPlayOffBetAck ACK;

		protected int BattleIndex;

		protected bool SupportA;

		public MakyouPlayoffSupportOp(int index, bool supportA)
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
