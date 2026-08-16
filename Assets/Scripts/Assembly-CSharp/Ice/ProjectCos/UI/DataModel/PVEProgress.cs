using System.Collections.Generic;
using Ice.ProjectCos.Protocol;
using UnityEngine;

namespace Ice.ProjectCos.UI.DataModel
{
	public class PVEProgress
	{
		private enum PVEDuplicationRecord
		{
			preOpenArea = 0,
			curOpenArea = 1,
			preOpenDuplication = 2,
			curOpenDuplication = 3,
			lastSelectDuplication = 4,
			_NUM = 5
		}

		public enum PVEType
		{
			Normal = 0,
			Hero = 1,
			MAXCOUNT = 2
		}

		private Dictionary<int, PVEChapter> _chapterList;

		public Dictionary<int, int> DuplicationDailyTimes;

		public Dictionary<int, int> DuplicationDailyBuyTimes;

		public int FreeSweepUsedCount;

		private PVELevel[] _selectionData;

		private PVELevel[] _progressData;

		private float[] _mapProgress;

		private int[] _normalDefaultDuplicationRecord;

		private int[] _heroDefaultDuplicationRecord;

		private ChapterType _chapterType;

		public bool isEliteOpen;

		public PVEType CurPVEType;

		public Dictionary<int, PVEChapter> ChapterList => null;

		public PVELevel CurSelectionData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PVELevel CurProgressData => null;

		public bool IsAreaSwitch => false;

		public bool IsDuplicationSwitch => false;

		public bool CheckNormalDupOpen => false;

		public bool CheckEliteDupOpen => false;

		public int PreOpenArea => 0;

		public int CurrentOpenArea => 0;

		public int CurrentOpenAreaNormal => 0;

		public int PreOpenDuplication => 0;

		public Vector3 CurDupPosition => default(Vector3);

		public int CurrentOpenDuplication => 0;

		public int CurrentOpenNormDuplication => 0;

		public int CurrentOpenHeroDuplication => 0;

		public bool isHeroDuplicationUnlock { get; private set; }

		public int LastSelectDuplication => 0;

		public int LastSelectDuplicationAreaId => 0;

		public Vector3 LastSelectDuplicationPosition => default(Vector3);

		public Vector3 CurOpenDuplicationPosition => default(Vector3);

		public void CloseAreaSwitch()
		{
		}

		public void CloseDupSwitch()
		{
		}

		public void SetDupPosition(float positionX)
		{
		}

		public bool CanAccessChapter(int chapterId)
		{
			return false;
		}

		public bool CheckLevelEnough(int chapterId, out int openLevel)
		{
			openLevel = default(int);
			return false;
		}

		public bool isPastLevel(int duplicationID)
		{
			return false;
		}

		public int GetChapterTotalStars(int chapterID)
		{
			return 0;
		}

		public Dictionary<int, PVEChapter> GetDuplicationByDifficulty(CfgProtoDuplication.DifficultyEnum difficulty)
		{
			return null;
		}

		public void CleanSecondDayData()
		{
		}

		public void ReloadFromProto(QuestProto proto, ChapterType chapterType = ChapterType.Normal)
		{
		}

		public void InitDefaultSelectDuplication()
		{
		}

		public void SetDefaultDuplication(int duplicationId)
		{
		}

		private void RefreshCurDuplications()
		{
		}

		private void ClearAllSelect(PVEChapter chapter)
		{
		}

		public PVELevel GetByDuplicationId(int duplicationId)
		{
			return null;
		}

		private PVELevel GetOrCreateLevel(int duplicationId)
		{
			return null;
		}

		public PVELevel GetOrCreateTempLevel(int duplicationId)
		{
			return null;
		}

		private List<PVELevel> OpenNextDuplication(bool include_zero_star = false)
		{
			return null;
		}

		public void DuplicationComplete(int duplicationId, int star, bool isTaskFirstFinish)
		{
		}
	}
}
