namespace Ice.ProjectCos.UI.GameOperations
{
	public class MailListOp : Operation
	{
		public int Form { get; set; }

		public int To { get; set; }

		public MailListOp()
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
