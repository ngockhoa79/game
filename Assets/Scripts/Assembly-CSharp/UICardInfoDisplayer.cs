using UnityEngine;

public class UICardInfoDisplayer : IceUIBase
{
	[SerializeField]
	private UIEventListener closeBtn;

	[SerializeField]
	private UILabel contentLabel;

	[SerializeField]
	private UIScrollView scrollView;

	public UIPanel Panel;

	public string Sentence;

	public bool ActiveSpine;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void close(GameObject btn)
	{
	}

	private int getPanelDepth()
	{
		return 0;
	}
}
