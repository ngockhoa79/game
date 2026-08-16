using Ice.ProjectCos.UI.DataModel;

namespace Ice.ProjectCos.UI.GameOperations
{
	public class MailAttachGetOp : Operation
	{
		private PlayerInfo mInfo;

		public int MailID { get; private set; }

		public bool RewardAll { get; private set; }

		public MailAttachGetOp()
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public MailAttachGetOp(int mailID)
			: base(isNeedResponse: false, 0, bShowLoadingBlock: false)
		{
		}

		public PlayerInfo GetDeltaPlayerInfo()
		{
			return null;
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
