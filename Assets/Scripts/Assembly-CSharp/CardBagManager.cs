using System;
using System.Collections.Generic;
using Ice.ProjectCos.Config;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class CardBagManager : IceUIBase
{
	public enum UIStatus
	{
		Show = 0,
		MultiSelect = 1,
		_NUM = 2
	}

	public class CardItemVisualizer : IceUIReusableList<HeroCouple>.IVisualizer
	{
		public readonly CardBagManager Owner;

		public CardItemVisualizer(CardBagManager owner)
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

	public class CardFragmentVisualizer : IceUIReusableList<HeroFragmentCouple>.IVisualizer
	{
		public readonly CardBagManager Owner;

		public CardFragmentVisualizer(CardBagManager owner)
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

		public void SetData(GameObject widget, HeroFragmentCouple heroCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UILabel countCardNumber;

	[SerializeField]
	private UILabel sellCardCount;

	[SerializeField]
	private UICardItemList cardList;

	[SerializeField]
	private UICardFragmentList cardFragmentList;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	[SerializeField]
	private UIEventListener SellButton;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private UIEventListener FilterButton;

	[SerializeField]
	private UIEventListener CancelButton;

	[SerializeField]
	private UIEventListener ArmyEditButton;

	[SerializeField]
	private UIEventListener DictButton;

	[SerializeField]
	private UIEventListener SellAllButton;

	[SerializeField]
	private UICardSellEnsure ensureMenu;

	[SerializeField]
	private UICardHighWarningEnsure warningMenu;

	[SerializeField]
	private GameObject ShowCardObj;

	[SerializeField]
	private GameObject CountCardObj;

	[SerializeField]
	private GameObject SellCountCardObj;

	[SerializeField]
	private UICardFilterPopup filterMenu;

	[SerializeField]
	private UILabel filterTips;

	[SerializeField]
	private UIEventListener eventAddCardBag;

	[SerializeField]
	private UINotifyRedDot rdHeroFragment;

	[SerializeField]
	private GameObject _emptySlot;

	[SerializeField]
	private IceAnimatorTotalCommander _emptyAnimator;

	[SerializeField]
	private UISprite spMainTitle;

	public IceUIBtnGroup CardTab;

	private List<Hero> Cards;

	private List<ItemHolding> CardFragments;

	private List<int> CardsOnField;

	private List<Hero> NormalSellingCart;

	private List<Hero> HighLevelSellingCart;

	private List<Hero> FinalSellingCart;

	private List<UICardItem> CardItems;

	private int highSellingCount;

	private int highSellingIndex;

	private ItemHolding removeFragment;

	private bool isNeverPopupWarningMenu;

	private bool isCardShowClosed;

	private HeroConfig fragmentCombineHero;

	private HeroTemplateExt heroTemplate;

	private ItemHolding heroFragmentHolding;

	public Action OnReturn;

	public Action OnHomePage;

	public Action<Hero> OnStrengthen;

	public Action<ItemHolding> OnSummon;

	public Action E_OnFormation;

	public Action E_OnDictOpen;

	public Action<string> E_OnChangeTab;

	private bool _initSellMode;

	private UIStatus mStatus;

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

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnSellClicked(GameObject obj)
	{
	}

	private void OnCardSelected(Hero holding, bool isSelected)
	{
	}

	private bool isCardCartEmpty()
	{
		return false;
	}

	private void OnSellEnsureClicked(GameObject obj)
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

	private void OnRefreshUI()
	{
	}

	private void OnRefreshUIAfterFilter()
	{
	}

	private void OnSellAllClicked(GameObject obj)
	{
	}

	private void OnSellCardsEnsure()
	{
	}

	private void OnSellResponse(object obj)
	{
	}

	private void OnFinishSold()
	{
	}

	private void OnFinishFilter()
	{
	}

	private void OnRefreshCardList()
	{
	}

	private void OnRefreshCardFragmentList()
	{
	}

	private void OnSellCardsCancel()
	{
	}

	private void OnWarningSellEnsure(Hero hero)
	{
	}

	private void OnWarningSellCancel()
	{
	}

	private void OnHighSellingCollect()
	{
	}

	private void OnPopupWarningMenu()
	{
	}

	private void MiddleToFinalSellMenu()
	{
	}

	private void OnCallFinalSellMenu()
	{
	}

	private void OnHighPopupSelected(bool flag)
	{
	}

	private void OnSwitchStatus(bool isInit)
	{
	}

	public bool IsSellMode()
	{
		return false;
	}

	private void OnSellButtonSwitch()
	{
	}

	private void clear()
	{
	}

	private void setData(bool switchStatus = true)
	{
	}

	private void RefreshCardCountLabel()
	{
	}

	private void SetFilterTips()
	{
	}

	private void InitCardListData()
	{
	}

	private void InitCardFragmentsListData()
	{
	}

	private void setStatus(string oldTabName, string newTabName)
	{
	}

	private void OnCardListEntered()
	{
	}

	private void OnFragmentListEntered()
	{
	}

	private void OnCardCombine(ItemHolding holding)
	{
	}

	public void OnCardCombineResponse(bool success, object response)
	{
	}

	private void _internal_refresh_fragments()
	{
	}

	private void ShowCombineCard(Hero card)
	{
	}

	private void OnCloseCardShow()
	{
	}

	private void OnSetButtonGroupActive(bool flag)
	{
	}

	public void OnCardClicked(Hero card)
	{
	}

	private void onSellCardFromSrcPopup()
	{
	}

	public void OnViewHero(Hero h)
	{
	}

	public void SetCardItem(UICardItemGroup group)
	{
	}

	private void _show_empty_bag_(bool bShow)
	{
	}
}
