using Ice.ProjectCos.Protocol;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class ChatSendOp : Operation
	{
		public C2SChatReq.TypeEnum ChatType { get; set; }

		public string Message { get; set; }

		public ChatSendOp()
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
