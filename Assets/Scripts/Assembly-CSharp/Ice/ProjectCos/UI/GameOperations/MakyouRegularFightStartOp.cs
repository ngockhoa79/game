using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouRegularFightStartOp : Operation
	{
		public S2CCrossPersonBattleAck ACK;

		private string UID;

		public MakyouRegularFightStartOp(string UID)
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
