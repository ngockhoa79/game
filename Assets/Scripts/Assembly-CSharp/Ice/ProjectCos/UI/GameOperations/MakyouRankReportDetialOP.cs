namespace Ice.ProjectCos.UI.GameOperations
{
	public class MakyouRankReportDetialOP : Operation
	{
		public int id;

		public MakyouRankReportDetialOP()
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
