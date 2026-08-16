using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ItemBagManager : IceUIBase
{
	public class ItemItemVisualizer : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly ItemBagManager Owner;

		public ItemItemVisualizer(ItemBagManager owner)
		{
		}

		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, ItemCouple itemCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UIItemList itemList;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener BackButton;

	[SerializeField]
	private GameObject _emptyGo;

	[SerializeField]
	private IceAnimatorTotalCommander _emptyAnim;

	public Action OnHomePage;

	public Action OnBackPage;

	private List<ItemHolding> Items;

	public void SetData()
	{
	}

	private void setData()
	{
	}

	private void InitItemListData()
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

	private void OnItemSelected(ItemHolding holding, bool isSelected)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnBackClicked(GameObject obj)
	{
	}

	private void _show_empty_anim(bool bShow)
	{
	}
}
