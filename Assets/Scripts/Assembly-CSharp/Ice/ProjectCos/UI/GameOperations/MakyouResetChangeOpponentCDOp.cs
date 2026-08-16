using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouResetChangeOpponentCDOp : Operation
	{
		public S2CCrossPersonClearChangeCdAck ACK;

		public MakyouResetChangeOpponentCDOp()
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
