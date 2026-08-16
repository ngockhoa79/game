using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ChatListOp : Operation
	{
		public C2SChatReq.TypeEnum channelType;

		public ulong LastID { get; set; }

		public ChatListOp(C2SChatReq.TypeEnum channel)
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
