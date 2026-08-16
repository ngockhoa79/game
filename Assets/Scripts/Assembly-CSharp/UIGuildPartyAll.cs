using System;
using Ice.ProjectCos.ConfigGenerator.Template;
using UnityEngine;

public class UIGuildPartyAll : MonoBehaviour
{
	private const string TitileTip = "Guild_Food_tip_1";

	public UIGuildPartyMenuItem[] Menus;

	public UILabel Title;

	public UILabel CurrencyLabel;

	public UILabel CrystalLabel;

	public UILabel Indicator;

	private bool isPresident;

	private bool isVicePresident;

	private Action presidentOperated;

	public void Set(bool isPresident, bool isVicePresident, Action presidentOperated)
	{
	}

	private void setIndicator()
	{
	}

	private void handleMenuClicked(GuildPartyTemplate t)
	{
	}

	private void req(GuildPartyTemplate t)
	{
	}

	private void tip(string t)
	{
	}
}
