using UnityEngine;

public class GuildCreateCtrller : IceUIBase
{
	public UIInput NameInput;

	public UIEventListener ChangeIconBtn;

	public UIEventListener CreateBtn;

	public UIEventListener CloseBtn;

	public UILabel CreatePrice;

	public GuildIconSelector uiGuildIconSelector;

	public UISprite GuildIcon;

	private int curSelectIndex;

	public void SetData()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void SetGuildIcon(int iconIndex)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private void OnChangeIconClicked(GameObject obj)
	{
	}

	private void OnCreateClicked(GameObject obj)
	{
	}

	private void OnCloseClicked(GameObject obj)
	{
	}
}
