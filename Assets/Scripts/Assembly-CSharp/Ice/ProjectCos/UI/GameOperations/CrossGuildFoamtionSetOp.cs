using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CrossGuildFoamtionSetOp : Operation
	{
		public S2CCrossGuildFoamtionSetAck ACK;

		private int line;

		private int column;

		private bool isUp;

		public CrossGuildFoamtionSetOp(int _line, int _column, bool _isUp)
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
