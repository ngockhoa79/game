using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class GearBagManager : IceUIBase
{
	public class GearItemVisualizer : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly GearBagManager Owner;

		public GearItemVisualizer(GearBagManager owner)
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

	public class GearFragVisualizer : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly GearBagManager Owner;

		public GearFragVisualizer(GearBagManager owner)
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

		public void SetData(GameObject widget, ItemCouple fragCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UIItemList gearList;

	[SerializeField]
	private UIItemList gearFragList;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener SellButton;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private UIEventListener BackButton;

	[SerializeField]
	private UIEventListener FilterButton;

	[SerializeField]
	private UIEventListener AddSlotButton;

	[SerializeField]
	private UIEventListener CancelButton;

	[SerializeField]
	private UIEventListener ArmyEditButton;

	[SerializeField]
	private UIEventListener DictButton;

	[SerializeField]
	private UIGearFilterPopup filterMenu;

	[SerializeField]
	private UILabel filterTips;

	[SerializeField]
	private UINotifyRedDot rdGearFragment;

	[SerializeField]
	private UILabel lbCount;

	[SerializeField]
	private UILabel lbSellCount;

	[SerializeField]
	private GameObject goCountRoot;

	[SerializeField]
	private GameObject goSellCountRoot;

	[SerializeField]
	private GameObject goGearFragment;

	[SerializeField]
	private GameObject _emptyGo;

	[SerializeField]
	private IceAnimatorTotalCommander _emptyAnimator;

	[SerializeField]
	private UISprite spMainTitle;

	private List<ItemHolding> Gears;

	private List<ItemHolding> GearFragments;

	private List<ItemHolding> NormalSellingCart;

	private List<ItemHolding> HighLevelSellingCart;

	private List<ItemHolding> FinalSellingCart;

	private List<UIGearItem> GearItems;

	[SerializeField]
	private UIEventListener eventAddCardBag;

	private int highSellingCount;

	private int highSellingIndex;

	private bool IsContinueHighQualitySell;

	private bool IsEnsureSell;

	private GameObject popupObj;

	private GameObject sellMenuObj;

	private UIPopup2btn popupUI;

	private UICardSellEnsure sellUI;

	private ItemHolding removeFragment;

	public IceUIBtnGroup GearTab;

	public Action OnReturn;

	public Action OnHomePage;

	public Action OnBackPage;

	public Action<ItemHolding> OnForge;

	public Action E_OnFormation;

	public Action E_OnDictOpen;

	public Action<string> E_OnChangeTab;

	private bool _initSellMode;

	private CardBagManager.UIStatus mStatus;

	public string CurrentTabButton { get; set; }

	public bool InitSellMode
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public void SetData()
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

	protected override void DoShowOnscreen()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	private void RefreshGearCountLabel()
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void clear()
	{
	}

	private void setData(bool switchStatus = true)
	{
	}

	private void SetFilterTips()
	{
	}

	private void OnSwitchStatus(bool isInit)
	{
	}

	private bool isGearCartEmpty()
	{
		return false;
	}

	private void OnSellEnsureClicked(GameObject obj)
	{
	}

	private void OnPopupWarningMenu()
	{
	}

	private void OnWarningEntered()
	{
	}

	private void OnWarningClosed()
	{
	}

	private void ClosePopupUI()
	{
	}

	private void OnCallFinalSellMenu()
	{
	}

	private void ShowSellPrizePopup(int totalPrice)
	{
	}

	private void OnSellEntered()
	{
	}

	private void CloseSellUI()
	{
	}

	private void OnSellClosed()
	{
	}

	private void OnSellResponse(object obj)
	{
	}

	private void OnRefreshUI()
	{
	}

	private void OnSellClicked(GameObject obj)
	{
	}

	private void OnSellAllClicked(GameObject obj)
	{
	}

	private void OnGearSelected(ItemHolding holding, bool isSelected)
	{
	}

	private void OnSellButtonSwitch()
	{
	}

	private void InitGearListData()
	{
	}

	private void InitGearFragmentsListData()
	{
	}

	private void setStatus(string oldTabName, string newTabName)
	{
	}

	private void OnGearListEntered()
	{
	}

	private void OnFragmentListEntered()
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnGearStrengthen(ItemHolding holding)
	{
	}

	private void OnGearForge(ItemHolding holding)
	{
	}

	private void OnGearForgeResponse(bool success, object response)
	{
	}

	private void OnFilterClicked(GameObject obj)
	{
	}

	private void OnFilterEnsure()
	{
	}

	private void OnFilterCancel()
	{
	}

	public void SetGearItem(UIGearItemGroup group)
	{
	}

	private void _show_empty_anim(bool bShow)
	{
	}
}
