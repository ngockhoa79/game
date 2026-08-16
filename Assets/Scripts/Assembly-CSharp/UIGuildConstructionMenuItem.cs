using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGuildConstructionMenuItem : MonoBehaviour
{
	public enum BtnType
	{
		Normal = 0,
		VipLimit = 1,
		Over = 2
	}

	private string[] WordTitleSprites;

	private string[] IconSprites;

	private string[] IconBGSprites;

	private const string GoldSprite = "icon_gold";

	private const string CrystalSprite = "icon_diamonds1";

	private const string VIP = "VIP";

	public UISprite WordTitle;

	public UISprite Icon;

	public UISprite IconBG;

	public UILabel ActiveValue;

	public UILabel Contribution;

	public UISprite PriceIcon;

	public UILabel PriceLabel;

	public GameObject Over;

	public GameObject VipLimit;

	public UIEventListener Btn;

	public IceAnimatorTotalCommander Anim;

	private int gold;

	private int crystal;

	public void Set(GuildDonateTemplate t, bool bought, int vip, int gold, int crystal, Action<UIGuildConstructionMenuItem, bool, CurrencyType, GuildDonateTemplate> onClicked)
	{
	}

	public void SetBtnOver()
	{
	}

	public void PlayAnim()
	{
	}

	private void setBtn(BtnType t, Action<UIGuildConstructionMenuItem, bool, CurrencyType, GuildDonateTemplate> onClicked, GuildDonateTemplate d)
	{
	}

	private bool isSufficient(PriceInfo i, int g, int c)
	{
		return false;
	}

	private void setBtnNormal(PriceInfo price)
	{
	}

	private void setBtnVipLimit(int vip)
	{
	}
}
