using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouPlayoffGetLatestFormationOp : Operation
	{
		public C2SCrossPersonPlayOffGetFormationAck ACK;

		public string PlayerID;

		public int BattleIndex;

		public BattleFormationProto LatestFormation;

		public MakyouPlayoffGetLatestFormationOp(string player_id, int battle_index)
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
