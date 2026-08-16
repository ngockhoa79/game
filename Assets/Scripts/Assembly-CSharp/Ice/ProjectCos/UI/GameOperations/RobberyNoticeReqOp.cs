namespace Ice.ProjectCos.UI.GameOperations
{
	public class RobberyNoticeReqOp : Operation
	{
		private RobberyInfoReqOp.EType type;

		public RobberyNoticeReqOp(RobberyInfoReqOp.EType type)
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
