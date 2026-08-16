using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildTransferLeaderOp : Operation
	{
		public S2CGuildTransferPresidentAck ACK;

		protected int playerID;

		public GuildTransferLeaderOp(int player)
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
