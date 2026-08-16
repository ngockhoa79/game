using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public abstract class GuildInfoChangeOp : Operation
	{
		public S2CGuidlInfoChangeAck ACK;

		public C2SGuidlInfoChangeReq.TypeEnum infoType;

		public GuildInfoChangeOp()
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
