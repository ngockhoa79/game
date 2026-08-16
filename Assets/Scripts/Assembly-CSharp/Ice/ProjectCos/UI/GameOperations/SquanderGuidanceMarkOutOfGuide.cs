using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class SquanderGuidanceMarkOutOfGuide : Operation
	{
		public S2CNewStagesSaveDataAck ACK;

		public SquanderGuidanceMarkOutOfGuide()
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
