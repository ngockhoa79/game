using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UILuggage : IceUIBase
{
	public class FilterState
	{
		public readonly string Tab;

		public readonly string Filter;

		public readonly string Type;

		public readonly bool IsSellMode;

		public FilterState(string tab, string filter, string type, bool isSellMode)
		{
		}

		public FilterState SetTab(string tab)
		{
			return null;
		}

		public FilterState SetFilter(string filter)
		{
			return null;
		}

		public FilterState SetType(string type)
		{
			return null;
		}

		public FilterState SetSellMode(bool isSellMode)
		{
			return null;
		}
	}

	public class GearVisualizer : IceUIReusableList<ItemHolding>.IVisualizer
	{
		public readonly UILuggage Owner;

		public GearVisualizer(UILuggage owner)
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

		public void SetData(GameObject widget, ItemHolding item)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class SkillVisualizer : IceUIReusableList<ItemHolding>.IVisualizer
	{
		public readonly UILuggage Owner;

		public SkillVisualizer(UILuggage owner)
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

		public void SetData(GameObject widget, ItemHolding item)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class MiscVisualizer : IceUIReusableList<ItemHolding>.IVisualizer
	{
		public readonly UILuggage Owner;

		public MiscVisualizer(UILuggage owner)
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

		public void SetData(GameObject widget, ItemHolding holding)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public Action OnHomePage;

	public Action<List<ItemHolding>> OnSell;

	public Action<IceUIReusableList<ItemHolding>, FilterState> OnList;

	public Action<GearHolding> OnGearStrengthen;

	public Action<ItemHolding> OnGearComplement;

	public Action<ItemHolding> OnGearForge;

	public Action<SkillHolding> OnSkillUpgrade;

	public UIEventListener HomePageButton;

	public UIEventListener SellButton;

	public UIEventListener ReturnButton;

	public UIEventListener EnsureButton;

	public IceUIBtnGroup Tab;

	public IceUIBtnGroup GearFilter;

	public IceUIBtnGroup SkillFilter;

	public UILgList GearList;

	public UILgList SkillList;

	public UILgList MiscList;

	private readonly List<ItemHolding> selection;

	private GameObject SellMenuObj;

	private UICardSellEnsure SellMenu;

	public FilterState CurrentState { get; private set; }

	public IceUIReusableList<ItemHolding> ActiveList => null;

	private IceUIBtnGroup getFilter(FilterState state)
	{
		return null;
	}

	private UILgList getList(FilterState state)
	{
		return null;
	}

	private void setState(FilterState newState)
	{
	}

	private void refreshSellButton()
	{
	}

	private void ClearSelection()
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

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
		Tab?.EnterScreen(null, false, true, false);
		onEnterScreen?.Invoke();
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
		Tab?.ExitScreen(null, false, true);
		onExitScreen?.Invoke();
	}

	protected override void DoDispose()
	{
	}

	protected override void DoClearData()
	{
	}

	public void OnPopup(ItemHolding holding)
	{
	}

	public void OnGearForgePopup(ItemHolding holding)
	{
	}

	private void OnCloseCallback()
	{
	}

	public void OnViewHolding(ItemHolding holding)
	{
	}
}
