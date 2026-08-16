using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICardFragmentItem : IceUIBase
{
	public UILabel CardName;

	public UILabel CardChip;

	public UILabel CardChipNumber;

	public UICardHalfBodyPortrait CardPortrait;

	public UISprite CanSummonImg;

	[SerializeField]
	private UIEventListener SummonButton;

	public Action<ItemHolding> OnCombine;

	private bool canSummon;

	public UIDragScrollView Dragger;

	public ItemHolding herofragment { get; private set; }

	public void SetData(ItemHolding herofragment)
	{
	}

	public void LoadPortrait()
	{
	}

	private void onCardLoad()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoClearData()
	{
	}

	private void OnSummonClicked(GameObject obj)
	{
	}

	private void OnPress(GameObject go, bool pressed)
	{
	}

	private void OnDrag(GameObject go, Vector2 delta)
	{
	}

	private void OnScroll(GameObject go, float delta)
	{
	}
}
