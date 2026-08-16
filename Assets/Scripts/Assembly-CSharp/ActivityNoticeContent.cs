public class ActivityNoticeContent
{
	public enum State
	{
		None = 0,
		Hot = 1,
		New = 2
	}

	public string Title;

	public string Content;

	public string ShortTitle;

	public State state;
}
