using Ice.ProjectCos.Config;
using Ice.ProjectCos.I18N;

public class ConfigManager
{
	private string mParentDirectory;

	private bool bInitialized;

	private static ConfigManager instance;

	public CfgProtoProfession ProfessionDesc;

	public CfgFsmResources FsmResourcesDesc;

	public CfgProtoDuplication DuplicateDesc;

	public StrTranslator Translator;

	public bool Initialized => false;

	public CfgChapterTexts ChapterText { get; private set; }

	public CfgLevelText LevelText { get; private set; }

	public GlobalConfigTemplateExt GlobalConfigDesc { get; private set; }

	private ConfigManager()
	{
	}

	public static ConfigManager Instance()
	{
		return null;
	}

	public bool Initial(bool bForceRefresh = false)
	{
		return false;
	}

	public void CheckResources()
	{
	}

	public int GetFormationOpenCountByLevel(int level)
	{
		return 0;
	}
}
