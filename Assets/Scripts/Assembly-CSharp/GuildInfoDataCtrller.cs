using UnityEngine;

public class GuildInfoDataCtrller : MonoBehaviour
{
	public UISprite guildIcon;

	public UILabel guildName;

	public UILabel guildId;

	public UILabel guildLv;

	public UILabel activeNow;

	public UILabel memberNow;

	public UILabel memberMax;

	public UILabel guildNotice;

	public UILabel myContribution;

	public UILabel activeMax;

	public UISprite activeBar;

	public UILabel presidentName;

	private GuildInfo info;

	public void SetData(GuildInfoPageType _pageType, GuildInfo _info = null)
	{
	}

	private void RefreshUI(GuildInfoPageType _pageType)
	{
	}

	public void ClearData()
	{
	}
}
