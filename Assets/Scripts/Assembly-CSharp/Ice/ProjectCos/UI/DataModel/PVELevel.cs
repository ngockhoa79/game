namespace Ice.ProjectCos.UI.DataModel
{
	public class PVELevel
	{
		private ChapterType _chapterType;

		private int _duplicationId;

		private int _times;

		private int _star;

		public bool bAccess;

		public bool bSelected;

		public bool bPast;

		public bool IsTaskFirstFinish;

		public bool IsTaskPickAlready;

		public ChapterType ChapterType => default(ChapterType);

		public int DuplicationId => 0;

		public int Time => 0;

		public int Star
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int QuestId { get; set; }

		public PVELevel(int duplicationId, int star, int times = 0, bool canAccess = true, ChapterType chapterType = ChapterType.Normal, bool isPast = false, bool isTaskFirstFinish = false, bool isTaskPickAlready = false)
		{
		}

		public int GetStatimaConsume()
		{
			return 0;
		}
	}
}
