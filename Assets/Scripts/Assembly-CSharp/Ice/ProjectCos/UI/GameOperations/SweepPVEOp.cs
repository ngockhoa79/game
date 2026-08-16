namespace Ice.ProjectCos.UI.GameOperations
{
	public class SweepPVEOp : Operation
	{
		public int DuplicateID { get; private set; }

		public int chapterType { get; private set; }

		public int SweepTimes { get; private set; }

		public SweepPVEOp(int duplicateID, int sweepTimes, int chapterType)
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
