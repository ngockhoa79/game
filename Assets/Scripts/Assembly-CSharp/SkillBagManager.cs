using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class SkillBagManager : IceUIBase
{
	public class SkillItemVisualizer : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly SkillBagManager Owner;

		public SkillItemVisualizer(SkillBagManager owner)
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

		private bool _check_skill_can_upgrade_(ItemHolding itemHolding)
		{
			return false;
		}
	}

	[SerializeField]
	private UIItemList skillList;

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener SellButton;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private UIEventListener FilterButton;

	[SerializeField]
	private UIEventListener CancelButton;

	[SerializeField]
	private UIEventListener SkillRobButton;

	[SerializeField]
	private UIEventListener ArmyEditButton;

	[SerializeField]
	private UIEventListener BackPageButton;

	[SerializeField]
	private UIEventListener DictButton;

	[SerializeField]
	private UILabel FilterTips;

	[SerializeField]
	private UISkillFilterPopup filterMenu;

	[SerializeField]
	private UILabel lbCount;

	[SerializeField]
	private UILabel lbSellCount;

	[SerializeField]
	private GameObject goCount;

	[SerializeField]
	private GameObject goSellCount;

	[SerializeField]
	private GameObject _emptyGo;

	[SerializeField]
	private IceAnimatorTotalCommander _emptyAnim;

	[SerializeField]
	private UISprite spMainTitle;

	public Action OnHomePage;

	public Action OnBackPage;

	public Action E_OnFormation;

	public Action E_OnDictOpen;

	private GameObject popupObj;

	private GameObject sellMenuObj;

	private UIPopup2btn popupUI;

	private UICardSellEnsure sellUI;

	private List<SkillHolding> Skills;

	private List<ItemHolding> NormalSellingCart;

	private List<ItemHolding> HighLevelSellingCart;

	private List<ItemHolding> FinalSellingCart;

	private List<UISkillItem> SkillItems;

	[SerializeField]
	private UIEventListener eventAddCardBag;

	private int highSellingCount;

	private int highSellingIndex;

	private bool IsContinueHighQualitySell;

	private bool IsEnsureSell;

	private CardBagManager.UIStatus mStatus;

	private bool _initSellMode;

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

	private void SetFilterTips()
	{
	}

	private void setData()
	{
	}

	private void InitSkillListData()
	{
	}

	private void OnSwitchStatus(bool isInit)
	{
	}

	private void OnSellButtonSwitch()
	{
	}

	private bool isSkillCartEmpty()
	{
		return false;
	}

	private void OnSellClicked(GameObject obj)
	{
	}

	private void OnSellEnsureClicked(GameObject obj)
	{
	}

	private void OnSkillRobClicked(GameObject go)
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

	private void OnSellEntered()
	{
	}

	private void OnSellClosed()
	{
	}

	private void CloseSellUI()
	{
	}

	private void OnSellResponse(object obj)
	{
	}

	private void OnRefreshUI()
	{
	}

	private void OnRefreshUIAfterFilter()
	{
	}

	private void OnRefreshSkillList()
	{
	}

	private void OnRefreshSkillListAfterFilter()
	{
	}

	private void OnSkillSelected(ItemHolding holding, bool isSelected)
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

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	private void RefreshSkillCountLabel()
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

	protected override void DoDispose()
	{
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnBackClicked(GameObject obj)
	{
	}

	private void OnDictButtonClicked(GameObject obj)
	{
	}

	private void OnSkillStrengthen(ItemHolding holding)
	{
	}

	public void SetSkillItem(UISkillItemGroup group)
	{
	}

	private void _show_empty_anim(bool bShow)
	{
	}
}
