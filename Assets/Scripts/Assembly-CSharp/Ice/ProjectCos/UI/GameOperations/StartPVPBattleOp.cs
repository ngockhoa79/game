using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class StartPVPBattleOp : Operation
	{
		public S2CPVPBattleStartAck ACK;

		public Player Challenger { get; private set; }

		public BattleReport BattleReport { get; private set; }

		public StartPVPBattleOp(Player challenger)
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
