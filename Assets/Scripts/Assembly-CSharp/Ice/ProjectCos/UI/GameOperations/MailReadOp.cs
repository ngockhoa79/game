namespace Ice.ProjectCos.UI.GameOperations
{
	public class MailReadOp : Operation
	{
		public int MailID { get; set; }

		public MailReadOp()
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
