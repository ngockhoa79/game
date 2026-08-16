using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class SquanderGuidanceMarkUnderGuide : Operation
	{
		public S2CNewStagesSaveDataAck ACK;

		private int index;

		public SquanderGuidanceMarkUnderGuide(int index)
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
