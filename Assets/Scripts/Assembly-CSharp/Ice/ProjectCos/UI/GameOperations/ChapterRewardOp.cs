namespace Ice.ProjectCos.UI.GameOperations
{
	public class ChapterRewardOp : Operation
	{
		public int ChapterID { get; private set; }

		public int RewardID { get; private set; }

		public ChapterRewardOp(int chapterID, int rewardID)
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
