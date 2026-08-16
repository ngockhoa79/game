using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public static class PopupManager
{
	private static Action E_OnAddCardBagSlotEnsure;

	private static Action E_OnAddEquipBagSlotEnsure;

	private static Action E_OnAddSkillBagSlotEnsure;

	private static bool UsingFlashFloatingboard;

	private static UIPopupCardReward uiPopupFCardReward;

	private static PopupFirstCharge uiPopupCharge;

	private static ChargeInfo info;

	private static bool isFirstCharge;

	private static UIPopupCardBagFull cardBagFullPopup;

	private static UIPopupGearBagFull gearBagFullPopup;

	private static UIPopupSkillBagFull skillBagFullPopup;

	private static UINActivityNotice uiActivityNotice;

	public static Action E_OnAnounceClose;

	private static UIPopupExchangeGold uiPopupExchangeGold;

	private static UIPopupFightReward uiPopupFightReward;

	public static UIMultiItemBuy uiMultiItemBuy;

	public static AbstractItem itembuy;

	public static UIMultiItemUse uiMultiItemUse;

	public static ItemHolding useItemHolding;

	private static UINameChange uiNameChange;

	private static Action<string> OnNameChangeSuccess;

	public static UIPopupUpdateClient uiPopupUpdateClient;

	public static void PopupAddCardBagSlot(Action onEnsure)
	{
	}

	private static void OnAddCardBagSlotEnsure()
	{
	}

	private static void OnAddCardBagSlotClose()
	{
	}

	public static void PopupAddEquipBagSlot(Action onEnsure)
	{
	}

	private static void OnAddEquipBagSlotEnsure()
	{
	}

	private static void OnAddEquipBagSlotClose()
	{
	}

	public static void PopupAddSkillBagSlot(Action onEnsure)
	{
	}

	private static void OnAddSkillBagSlotEnsure()
	{
	}

	private static void OnAddSkillBagSlotClose()
	{
	}

	public static void PopupBuyFragmentRobTimes(bool bUsingFlashFloatingboard = false)
	{
	}

	private static void EnsureBuyFragmentRobTimes()
	{
	}

	public static void PopupCardPrize(List<ThingHolding> data, Action E_OnPopupClose)
	{
	}

	private static void OnPopuCardRewardEnter()
	{
	}

	private static void OnPopupCardRewardExit()
	{
	}

	public static void PopupChargeAward(int id, bool bFirstCharge)
	{
	}

	private static void OnPopupChargeEntered()
	{
	}

	private static void OnPopupChargeClosed()
	{
	}

	private static bool _need_poopup_charge_()
	{
		return false;
	}

	private static void _set_popup_charge_data()
	{
	}

	public static bool CheckAllSpaceEnoughOne(bool allowPopup = true, bool bCheckCardBag = true, bool bCheckGearBag = true, bool bCheckSkillBag = true)
	{
		return false;
	}

	public static bool CheckAllSpaceEnoughOneFormSrc(List<ThingHolding> resultList, bool allowPopup = true)
	{
		return false;
	}

	public static bool CheckAllSpaceEnoughExactlyFormSrc(List<ThingHolding> resultList)
	{
		return false;
	}

	public static bool CheckCardBagSpaceEnough(bool allowPopup = true, int needSpace = 1)
	{
		return false;
	}

	private static void OnCardBagFullPopupEntered()
	{
	}

	private static void OnCardBagFullPopupClosed()
	{
	}

	public static bool CheckGearBagSpaceEnough(bool allowPopup = true, int needSpace = 1)
	{
		return false;
	}

	private static void OnGearBagFullPopupEntered()
	{
	}

	private static void OnGearBagFullPopupClosed()
	{
	}

	public static bool CheckSkillBagSpaceEnough(bool allowPopup = true, int needSpace = 1)
	{
		return false;
	}

	private static void OnSkillBagFullPopupEntered()
	{
	}

	private static void OnSkillBagFullPopupClosed()
	{
	}

	public static void PopupAnnounceNotification(Action onClose, bool bShowMessage = false)
	{
	}

	private static void OnActivityNoticeEnter()
	{
	}

	public static bool IsMyCurrencyEnoughPopup(CurrencyType cType, int cost)
	{
		return false;
	}

	public static void PopupExchangeGold(Action onClose = null)
	{
	}

	private static void OnExchangeGoldEntered()
	{
	}

	private static void OnlyDisposePopupExchangeGold(Action callback)
	{
	}

	private static void ClosePopupExchangeGold(Action callback)
	{
	}

	private static void OnExchangeGold()
	{
	}

	public static void PupupFightReward(ThingHolding selectItem, ThingHolding other1, ThingHolding other2, Action onOK = null)
	{
	}

	private static void OnPopupFightRewardEnter()
	{
	}

	private static void OnPopupFightRewardExit()
	{
	}

	public static void PopupMultiItemBuy(AbstractItem abItem, Action<AbstractItem, int> callback, int min, int max, int cur, int singlePrice, CurrencyType payType = CurrencyType.Crystal)
	{
	}

	private static void OnPopupMultiItemBuyEntered()
	{
	}

	public static void CleanPopupMultiItemBuy()
	{
	}

	public static void PopupMultiItemUse(ItemHolding itemH, Action<ItemHolding, int> callback, int min, int max, int cur)
	{
	}

	private static void OnPopupMultiItemUseEntered()
	{
	}

	public static void CleanPopupMultiItemUse()
	{
	}

	public static void PupupNameChange(Action<string> onNameChangeSuccess)
	{
	}

	private static void OnPopupNameChangeEntered()
	{
	}

	private static void OnNameChange(string name)
	{
	}

	private static void _handle_change_name(string name)
	{
	}

	private static void ClosePopupNameChange()
	{
	}

	public static void PopupUpdateClient(string version, string content, string url)
	{
	}

	private static void OnPopupUpdateEntered()
	{
	}
}
