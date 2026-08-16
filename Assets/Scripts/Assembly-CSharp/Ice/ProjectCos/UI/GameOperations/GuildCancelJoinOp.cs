using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildCancelJoinOp : Operation
	{
		public S2CGuildJoinCancelAck ACK;

		protected int guildID;

		public GuildCancelJoinOp(int guild_id)
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
