using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIGuildConstruction : MonoBehaviour
{
	public UIGuildConstructionScrollingBoard Board;

	public UIGuildConstructionMenuItem[] Menus;

	public UILabel Participation;

	public UILabel CurrencyLabel;

	public UILabel GoldLabel;

	public UILabel CrystalLabel;

	public UILabel Indicator;

	public void Set()
	{
	}

	private void refreshCurrency()
	{
	}

	private void setIndicator()
	{
	}

	private void req()
	{
	}

	private void ack(GuildDonateInfoProto proto)
	{
	}

	private void handleMenuClicked(UIGuildConstructionMenuItem menu, bool sufficient, CurrencyType currency, GuildDonateTemplate t)
	{
	}

	private void inSufficientTip(CurrencyType c)
	{
	}

	private void tip(string t)
	{
	}
}
