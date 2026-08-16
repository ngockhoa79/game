using System.Collections.Generic;
using Ice.ProjectCos.Protocol;

public class Activity
{
	private List<ActivityChapter> mChapters;

	private string mOpenPositionStr;

	public Dictionary<int, List<ActivityLevel>> mMaping;

	private const string NotifyExploreTimeDayKey = "LastNotifyExploreDayOfYear";

	public List<ActivityChapter> Chapters => null;

	public void SetChapterStatusFromProto(ActivityQuestProto proto)
	{
	}

	public void CreateMappingChapterLevel()
	{
	}

	public void LoadAllActivityChapter()
	{
	}

	private string generateOpenString()
	{
		return null;
	}

	public void CheckNewActivityOpen()
	{
	}

	public void NotifyActivityOpen()
	{
	}

	private void NotifyGuildBuildOpen()
	{
	}
}
