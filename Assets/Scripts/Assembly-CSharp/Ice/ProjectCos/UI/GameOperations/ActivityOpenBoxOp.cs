namespace Ice.ProjectCos.UI.GameOperations
{
	public class ActivityOpenBoxOp : Operation
	{
		public ActivityChapter mActivityChapter;

		public int LevelID { get; private set; }

		public ActivityOpenBoxOp(ActivityChapter ac, int levelID)
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
