public class UICmStarDisplayer : IceUIBase
{
	public enum EAlignment
	{
		Left = 0,
		Right = 1
	}

	public UISprite Prototype;

	public int MaxStarCount;

	public EAlignment Alignment;

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
}
