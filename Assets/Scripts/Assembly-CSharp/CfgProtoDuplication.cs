using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;

public class CfgProtoDuplication
{
	public enum DifficultyEnum
	{
		Normal = 1,
		Elite = 2
	}

	public enum StageTypeEnum
	{
		ZaBing = 1,
		SmallBoss = 2,
		Boss = 3,
		Cooperation = 4
	}

	public enum DropItemType
	{
		Card = 1,
		Equipment = 2,
		Skill = 3,
		Item = 4
	}

	public class DropItemContent
	{
		public DropItemType DropType;

		public int Id;

		public int Probability;
	}

	private Dictionary<int, CfgDuplicateTemplate> _duplicationDic;

	private List<int> _chapterCollection;

	public static int LastNormalDuplication { get; private set; }

	public static int LastHeroDuplication { get; private set; }

	public Dictionary<int, CfgDuplicateTemplate> DuplicationDic => null;

	public List<int> ChapterCollection => null;

	public bool Initialize()
	{
		return false;
	}

	private void CheckLastDuplication()
	{
	}

	public void SetChapterCollection()
	{
	}

	public static int GetDuplicationId(int chapterId, int index)
	{
		return 0;
	}

	public static void ParseDuplicationId(int duplicationId, out int chapterId, out int index)
	{
		chapterId = default(int);
		index = default(int);
	}

	public string GetChapterName(int chapterId)
	{
		return null;
	}

	public string GetName(int chapterId, int index)
	{
		return null;
	}

	public string GetEnemy(int chapterId, int index)
	{
		return null;
	}

	public CfgDuplicateTemplate GetDuplicationInfo(int duplicationId)
	{
		return null;
	}

	public CfgDuplicateTemplate GetDuplicationInfo(int chapterId, int index)
	{
		return null;
	}

	public int GetDuplicationCountByChapterId(int chapterId)
	{
		return 0;
	}
}
