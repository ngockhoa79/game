namespace Ice.ProjectCos.UI.GameOperations
{
	public class FriendRemoveOp : Operation
	{
		public int FriendIDToDel { get; set; }

		public FriendRemoveOp()
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
