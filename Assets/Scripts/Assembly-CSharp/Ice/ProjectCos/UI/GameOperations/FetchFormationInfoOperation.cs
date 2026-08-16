using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class FetchFormationInfoOperation : Operation
	{
		private ulong playerID;

		public S2CGetFormationInfoAck ACK;

		public FetchFormationInfoOperation(ulong playerID)
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
