using UnityEngine;

public class UIActivityNoticeContent : IceUIBase
{
	public UILabel lbTitle;

	public UILabel lbContent;

	public UISprite spEmptySeperator;

	public BoxCollider bcCollider;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	public void SetData(string title, string content)
	{
	}
}
