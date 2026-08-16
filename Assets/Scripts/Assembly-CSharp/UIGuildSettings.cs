using UnityEngine;

public class UIGuildSettings : IceUIBase
{
	public UIEventListener closeButton;

	public UIEventListener ButtonModifyName;

	public UIEventListener ButtonModifyIcon;

	public UILabel GuildName;

	public UISprite GuildIcon;

	public UILabel PriceName;

	public UILabel PriceIcon;

	protected int IconID;

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

	private void OnClose(GameObject btn)
	{
	}

	public void OnButtonModifyNameClick(GameObject go)
	{
	}

	public void OnButtonModifyIconClick(GameObject go)
	{
	}

	public void OnNameChanged(string new_name)
	{
	}

	public void OnIconChanged(int new_icon)
	{
	}
}
