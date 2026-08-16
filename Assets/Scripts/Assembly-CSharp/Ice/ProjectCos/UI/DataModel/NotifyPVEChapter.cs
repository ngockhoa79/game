namespace Ice.ProjectCos.UI.DataModel
{
	public class NotifyPVEChapter : INotifyEvent
	{
		private int _chapterId;

		public NotifyPVEChapter(int ChapterId)
		{
		}

		public override bool CheckStatus()
		{
			return false;
		}

		public static bool CheckChapterStatus(int ChapterId)
		{
			return false;
		}
	}
}
