using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildJoinAcceptOp : Operation
	{
		public S2CGuildAgreeAddAck ACK;

		protected ulong playerID;

		protected bool accept;

		public GuildJoinAcceptOp(ulong player, bool bAccept)
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
