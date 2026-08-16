using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildPromoteOp : Operation
	{
		public S2CGuildPromoteAck ACK;

		protected int playerID;

		public GuildPromoteOp(int player)
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
