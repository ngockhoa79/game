using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class PlayerInfoGetOp : Operation
	{
		public S2CQueryPlayerSummaryInfoAck ACK;

		public ulong PlayerIDToGet { get; set; }

		public PlayerInfoGetOp()
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
