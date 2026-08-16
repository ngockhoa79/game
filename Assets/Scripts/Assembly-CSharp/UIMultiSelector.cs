using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIMultiSelector : IceUIBase
{
	public class CardItemVisualizer2 : IceUIReusableList<HeroCouple>.IVisualizer
	{
		public readonly UIMultiSelector Owner;

		public CardItemVisualizer2(UIMultiSelector owner)
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

		public void SetData(GameObject widget, HeroCouple heroCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class GearItemVisualizer2 : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly UIMultiSelector Owner;

		public GearItemVisualizer2(UIMultiSelector owner)
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

		public void SetData(GameObject widget, ItemCouple gearCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class SkillItemVisualizer2 : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly UIMultiSelector Owner;

		public SkillItemVisualizer2(UIMultiSelector owner)
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

		public void SetData(GameObject widget, ItemCouple skillCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private IceUIBtnGroup ItemTypeTab;

	[SerializeField]
	private UICardItemList CardList;

	[SerializeField]
	private UIItemList GearList;

	[SerializeField]
	private UIItemList SkillList;

	[SerializeField]
	private UILabel lblRemain;

	public Action OnReturn;

	public Action OnHomePage;

	public Action<List<ItemHolding>> OnItemSelectComplete;

	private List<TabContent> mTabType;

	private TabContent mUsingTab;

	private MyCart mUsingCart;

	private MyCart mHeroCart;

	private MyCart mGearCart;

	private MyCart mSkillCart;

	private TabEnum _defaultTab;

	private void onChooseStatusChange()
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	public void SetTabs(List<TabContent> tabTypes)
	{
	}

	public void SetCart(TabEnum tabType, MyCart cart)
	{
	}

	public void SetCartLimit(int limit)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}

	private void onTabChange(int oldIdx, int newIdx)
	{
	}

	private void closeTab(TabContent tc, Action onComplete)
	{
	}

	private void openTab(TabContent tc, Action onComplete)
	{
	}

	private void CardListOpen(Action onComplete)
	{
	}

	private void GearListOpen(Action onComplete)
	{
	}

	private void SkillListOpen(Action onComplete)
	{
	}

	private void OnCardSelected(Hero holding, bool isSelected)
	{
	}

	private void OnHoldingSelected(ItemHolding holding, bool isSelected)
	{
	}

	private void OnGearUnload(ItemHolding gear)
	{
	}

	private void OnSkillUnload(ItemHolding skill)
	{
	}
}
