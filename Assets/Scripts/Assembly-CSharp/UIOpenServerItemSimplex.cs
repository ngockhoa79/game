using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIOpenServerItemSimplex : MonoBehaviour
{
	public enum BtnType
	{
		Buy = 0,
		Bought = 1
	}

	public UIEventListener Buy;

	public UIEventListener Bought;

	public UILabel ItemName;

	public UILabel ItemDesc;

	public UILabel OldPrice;

	public UILabel NewPrice;

	public UISprite Hot;

	public UISprite OnSale;

	public UIGrid Grid;

	public void Set(bool hot, bool isOnSale, int oPrice, int nPrice, BtnType t, OpenServerElement e)
	{
	}

	private void setUniIcon(OpenServerSaleItemTemplate.Item i)
	{
	}

	private void setNameDesc(ThingHolding th)
	{
	}

	private void handleBtnStatus(BtnType t, OpenServerElement e)
	{
	}

	private void handleBuy(OpenServerElement e)
	{
	}

	private List<ThingHolding> createBonusList(OpenServerElement e)
	{
		return null;
	}

	private void doReq(OpenServerElement e)
	{
	}

	private void tip(string t)
	{
	}

	private void inactive()
	{
	}
}
