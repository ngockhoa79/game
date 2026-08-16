using System;
using System.Collections.Generic;
using Ice.ProjectCos.ConfigGenerator.Template;
using Ice.ProjectCos.Protocol;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class FloatingBoardManager : MonoBehaviour
{
	private enum FloatingEnum
	{
		ConfirmDialog = 0,
		OkCancelDialog = 1,
		CustomDialog = 2
	}

	public enum SoundEffect
	{
		PopupNormal = 0,
		PopupCongratulation = 1,
		PopupDisappointed = 2
	}

	private class FloatingBoardContent
	{
		public FloatingEnum type;

		public string Tag;

		public string Message;

		public GameObject subPanel;

		public int height;

		public int width;

		public Action Event1;

		public Action Event2;

		public Action Event3;

		public bool bContainCollider;

		public SoundEffect soundFX;
	}

	public Action E_OnShow;

	public Action E_OnHide;

	private List<FloatingBoardContent> _messageList;

	private DateTime securityTime;

	private FloatingBoardNew _floatingBoard;

	public string GetSoundResource(SoundEffect soundFX)
	{
		return null;
	}

	public void Clear()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void ShowMessage(string tag, string message, Action onConfirm = null, Action onClose = null, bool bContainerCollider = true)
	{
	}

	public void ShowMessage(string message, Action onConfirm = null, Action onClose = null)
	{
	}

	public void ShowOkCancelMessage(string tag, string message, Action onOk = null, Action onCancel = null, Action onClose = null, bool bContainCollider = true)
	{
	}

	public void ShowChargeCancelMessage(string tag, string message, Action onCancel = null, Action onClose = null, bool replaceIntent = false, bool bContainCollider = true)
	{
	}

	public void ShowOkMessage(string tag, string message, Action onOk = null, Action onClose = null, bool bContainCollider = true)
	{
	}

	public void ShowAwardThings(List<ThingHolding> thingList, Action onClose = null, int redPack = -1, bool isFullPackage = false)
	{
	}

	public void ShowAwardThingsNoCardShow(List<ThingHolding> thingList, Action onClose = null, int redPack = -1)
	{
	}

	private void OnShowAwardThingsPopupClosed(List<ThingHolding> thingList, Action onClose)
	{
	}

	public bool ShowShopAppearPopup(Action<bool> onChoose)
	{
		return false;
	}

	public void ShowGearPopup(GearHolding gh, Action<bool, object> onActionComplete, Action onChange, Action onClose = null)
	{
	}

	public void ShowSkillPopup(SkillHolding sh, bool isTalent, Action<bool, object> onActionComplete, Action onChange, Action onClose = null)
	{
	}

	public void ShowButtonListPopup(string tag, string[] btnTexts, Action<int> onButtonClick)
	{
	}

	public void ShowInfoScourcePopup(ItemHolding itemHolding, Action<bool, object> onActionComplete, Action onBeforeGotoUI, Action onClose = null, bool bShowButtons = true)
	{
	}

	public void ShowBaQiItemInfoScourcePopup(ItemHolding itemHolding, CardBaQiItem item, Action<bool, object> onActionComplete, Action onBeforeGotoUI, Action onClose = null, bool bShowButtons = true)
	{
	}

	public void ShowSourcePopup(AbstractItem item, Action onClose = null, Action onSell = null)
	{
	}

	public void ShowBaQiProps(Hero hero, Action onClose = null)
	{
	}

	public void ShowBuyEnergyDialog(Action onBuySuccess, Action onBuyFail, Action onClose = null)
	{
	}

	public void ShowGuildSkillPopup(int c, UIGuildSkillItem.EState state, GuildActiveBuffTemplate t, GuildActiveBuffTextTemplate tt, Action<GuildActiveBuffTemplate> onOK)
	{
	}

	public void ShowDialogGotoCharge(string tag, string msg)
	{
	}

	public void ShowVipRelatedDialog(VipRelatedDialogType _type, int _currentMax, bool replaceIntent = false)
	{
	}

	public void ShowCustomPanel(GameObject subPanel, Action onEntered, int height = 404, int width = 656, Action onClose = null, bool bContainCollider = false, SoundEffect soundFX = SoundEffect.PopupNormal)
	{
	}

	public void CloseFloatingBoard(Action onCallback)
	{
	}

	private bool FindFloatingBoardComponentInScene()
	{
		return false;
	}

	public void ShowRestrainShip()
	{
	}

	public UIGuildMemberInfo ShowPlayerInfoPanel(Friend playerInfo, GuildMemberInfoProto.TypeEnum playerPost, int ArenaRank, Transform parentTransform, bool showGuildButtons = false)
	{
		return null;
	}
}
