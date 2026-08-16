using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using Ice.ProjectCos.UI.Intents;
using UnityEngine;

public class UIItemFromPopup : IceUIBase, IceUIReusableList<Navigator>.IVisualizer
{
	public enum Btn2Mode
	{
		ShowHideItemFromList = 0,
		Change = 1
	}

	public GameObject PartLeftInfo;

	public GameObject PartRightList;

	public IceAnimatorTotalCommander AnimateListOut;

	public IceAnimatorTotalCommander AnimateListHide;

	public UILabel lbName;

	public UILabel lbNum;

	public UILabel lbDesc;

	public UILabel lbBattleValue;

	public UILabel lbCountGearStone;

	public UILabel RefineLevel;

	public UILabel lbHechengNum;

	public UISprite spYouHave;

	public UISprite spFragCount;

	public UISprite spFragBg;

	public UISprite spGearStone;

	public UISprite spPopupTitle;

	public GameObject PartBattleValue;

	public GameObject PartGearStone;

	public GameObject PartHecheng;

	public UIGrid gdInfoList;

	public UniIcon Icon;

	public GearProperty GearMainProperty;

	public GearProperty GearMinro_1Property;

	public GearProperty GearMinro_2Property;

	public UIEventListener eventShowHide;

	public UIEventListener eventAction;

	public UIEventListener eventClose;

	protected UIButton bnAction;

	protected UIButton bnShowHide;

	public UIGrid gdButtons;

	public UISprite spActionText;

	public UISprite spButton2Text;

	public UILabel lbRedEquipDesc;

	[HideInInspector]
	public Action<bool, object> E_OnActionComplete;

	public Action E_Btn2Callback;

	public Action E_OnBeforeGotoUI;

	public Action E_OnClose;

	public UITable tbAddPos;

	public DropLevelListAnimator LevelList;

	protected List<DropLevelClient> mListDropParam;

	protected ItemHolding mData;

	protected bool mIsListShow;

	[HideInInspector]
	private Btn2Mode mBtn2Type;

	private Action<bool, object> _consumercallback;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
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

	public void SetData(GameObject widget, Navigator n)
	{
	}

	public void ClearData(GameObject widget)
	{
	}

	public void ShowInfoPartOnly()
	{
	}

	public void ListShowHideSwitch()
	{
	}

	public void ListAnimateShow()
	{
	}

	public void ListAnimateHide()
	{
	}

	public void SetData(ItemHolding item)
	{
	}

	protected virtual void setInfo()
	{
	}

	private void SetHechengPart(bool isActive, int num)
	{
	}

	private void setList()
	{
	}

	protected virtual void setActionButtonMode()
	{
	}

	public void SetButton2Mode(Btn2Mode type)
	{
	}

	public void OnActionButton2()
	{
	}

	public virtual void OnActionTake()
	{
	}

	public void OnItemActionGotoLevel(Navigator n, PVELevel PVELv)
	{
	}

	public void OnGotoUI(Navigator n)
	{
	}

	private void requestGearFormulaHeCheng(ItemHolding itemHolding)
	{
	}

	private void internal_gear_formula_combine_operation(ItemHolding itemHolding, Action<bool, object> E_OnActionComplete)
	{
	}

	private void requestCardFragCombine(ItemHolding itemHolding)
	{
	}

	private void requestUseConsumerItem(ItemHolding itemH)
	{
	}

	private int _item_count_(ItemHolding itemholding)
	{
		return 0;
	}

	private int _get_item_min_count(int id, int minCount)
	{
		return 0;
	}

	private void _internal_useitem_(ItemHolding itemH, int count)
	{
	}

	private string getSkillFragmentString(SkillHolding sh)
	{
		return null;
	}

	public void BtnEnable(bool isEnable)
	{
	}
}
