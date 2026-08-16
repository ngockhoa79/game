using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemCardForDraw : IceUIBase
{
	public UICardHalfBodyPortrait CardPortrait;

	[SerializeField]
	private UILabel CardID;

	[SerializeField]
	private UISprite spMaskOption;

	public UIEventListener eventTotal;

	public Action<Hero> E_OnClick;

	public Hero hero { get; private set; }

	public void Clear()
	{
	}

	public void SetHeroData(Hero hero)
	{
	}

	public void SetData(ItemHolding itemH)
	{
	}

	public void LoadPortrait(Action callback = null)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnClick(GameObject go)
	{
	}

	private void showMask()
	{
	}
}
