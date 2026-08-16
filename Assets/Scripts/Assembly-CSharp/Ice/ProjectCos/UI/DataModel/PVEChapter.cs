using System.Collections.Generic;

namespace Ice.ProjectCos.UI.DataModel
{
	public class PVEChapter
	{
		public bool[] ChapterRewardFlag;

		private ChapterType _chapterType;

		private int _chapterId;

		private Dictionary<int, PVELevel> _levelInfo;

		public int ChapterId => 0;

		public Dictionary<int, PVELevel> LevelInfo => null;

		public bool bNew => false;

		public bool bAccess => false;

		public bool bAllPast => false;

		public PVELevel GetLastLevel => null;

		private int duplicateCount => 0;

		public int Star => 0;

		public PVEChapter(int chapterId, ChapterType chapterType = ChapterType.Normal)
		{
		}

		public void SetData(int index, int star, int duplicationId, int countLeft, bool isPast, bool isTaskFirstFinish = false, bool isTaskPickAlready = false)
		{
		}
	}
}
