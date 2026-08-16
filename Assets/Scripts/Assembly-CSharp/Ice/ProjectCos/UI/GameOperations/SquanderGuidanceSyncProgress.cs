using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class SquanderGuidanceSyncProgress : Operation
	{
		public S2CNewStagesStepAck ACK;

		private int index;

		public SquanderGuidanceSyncProgress(int index)
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
