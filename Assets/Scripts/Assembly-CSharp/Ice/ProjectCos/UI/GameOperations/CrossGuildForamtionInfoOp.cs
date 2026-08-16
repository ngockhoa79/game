using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CrossGuildForamtionInfoOp : Operation
	{
		public S2CCrossGuildForamtionInfoAck ACK;

		public CrossGuildForamtionInfoOp()
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
