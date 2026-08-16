public class GuildPkData
{
	public enum LineFightResult
	{
		win = 0,
		draw = 1,
		lose = 2
	}

	public const int COLUMNS = 5;

	public const int LINES = 9;

	public const float BLOCK_PLAY_TIME = 1.7f;

	public static bool NeedRefreshRoot;

	public static int NormalScore => 0;

	public static int FlagScore => 0;

	public static CrossPkFillType CharToFillType(char _c)
	{
		return default(CrossPkFillType);
	}
}
