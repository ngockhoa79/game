public class UISJPlayerDisplayer : IceUIBase
{
	public UITexture Icon;

	public UILabel Name;

	public UILabel Lv;

	public UILabel Power;

	protected override void DoInit()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetDetails(string icon, string name, int power, int lv)
	{
	}
}
