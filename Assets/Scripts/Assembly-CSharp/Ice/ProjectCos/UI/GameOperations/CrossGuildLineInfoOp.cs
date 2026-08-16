using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CrossGuildLineInfoOp : Operation
	{
		public S2CCrossGuildLineInfoAck ACK;

		private int line;

		public CrossGuildLineInfoOp(int _line)
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
