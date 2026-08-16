using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardHalfBodyPortrait : IceUIBase
{
	[SerializeField]
	private UITexture BodyPortrait;

	[SerializeField]
	private UISprite CaseImg;

	[SerializeField]
	private UISprite NameBaseImg;

	[SerializeField]
	private UISprite Line;

	[SerializeField]
	private UICmStarDisplayer imgStars;

	[SerializeField]
	private UISprite imgCardType;

	[SerializeField]
	public UILabel CardName;

	[SerializeField]
	private bool bAsyncLoad;

	private HeroConfig card;

	public static Dictionary<string, Texture> Mlist;

	public HeroConfig Card
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void DoClearData()
	{
	}

	private void clear()
	{
	}

	private void set(HeroConfig card)
	{
	}

	private string caseName(HeroConfig card)
	{
		return null;
	}

	private string rarityNameBody(HeroConfig card)
	{
		return null;
	}

	private string rarityNameColor(HeroConfig card)
	{
		return null;
	}

	public void onLoadTexture(Action callback = null)
	{
	}

	protected override void DoDispose()
	{
	}
}
