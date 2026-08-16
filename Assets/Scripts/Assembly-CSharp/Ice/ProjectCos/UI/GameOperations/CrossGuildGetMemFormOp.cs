using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class CrossGuildGetMemFormOp : Operation
	{
		public S2CGetFormationInfoAck ACK;

		private ulong PlayerId;

		public CrossGuildGetMemFormOp(ulong _playerId)
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
