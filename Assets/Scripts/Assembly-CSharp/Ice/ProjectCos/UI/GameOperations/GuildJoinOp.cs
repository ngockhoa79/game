using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildJoinOp : Operation
	{
		public S2CGuildJoinAck ACK;

		protected int guildID;

		public GuildJoinOp(int guild_id)
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
