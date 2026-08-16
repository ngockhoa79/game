using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class GuildLeaveMsgOp : Operation
	{
		public S2CFriendLeaveMessageAck ACK;

		private int TargetID;

		private string Msg;

		public GuildLeaveMsgOp(int PlayerID, string msg)
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
