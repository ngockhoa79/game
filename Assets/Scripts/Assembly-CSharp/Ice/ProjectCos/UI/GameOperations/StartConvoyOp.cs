using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class StartConvoyOp : Operation
	{
		private ulong FriendID;

		public EscortTargetProto targetProto;

		public bool isStart { get; private set; }

		public StartConvoyOp(ulong friendId)
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
