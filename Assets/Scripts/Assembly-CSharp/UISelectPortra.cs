using System;
using UnityEngine;

public class UISelectPortra : IceUIBase
{
	public UISelectPortraSectionOwn SectionOwn;

	public UISelectPortraSectionOther SectionOther;

	public UIEventListener CloseButton;

	public UISprite ContentRoot;

	public UIScrollView ScrollView;

	public UIPanel ScrollViewPanel;

	public UIWidget ScrollContent;

	public Action<int> E_OnPortraChanged;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	public void SetData()
	{
	}

	private void OnClose(GameObject btn)
	{
	}

	public void OnPortraSelected(int heroID)
	{
	}
}
