public static class PVEUtil
{
	public static int NormMaxChapterId => 0;

	public static int HeroMaxChapterId => 0;

	public static int CurOpenNormDupId => 0;

	public static int CurOpenHeroDupId => 0;

	public static bool IsNormal(int duplicationId)
	{
		return false;
	}

	public static bool IsHero(int duplicationId)
	{
		return false;
	}

	public static int GetChapterId(int duplicationId)
	{
		return 0;
	}

	public static bool IsNormalChapter(int chapterId)
	{
		return false;
	}

	public static bool IsHeroChapter(int chapterId)
	{
		return false;
	}

	public static bool IsLastChapter(int duplicationId)
	{
		return false;
	}
}
