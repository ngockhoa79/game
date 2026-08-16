using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Ice.ProjectCos.UI.DataModel;

public class MainSceneManager : IceUIBase
{
	public enum ButtonType
	{
		Mail = 0,
		Chat = 1,
		Activity = 2,
		Task = 3,
		Gift = 4,
		Formation = 5,
		Card = 6,
		Luggage = 7,
		Enchance = 8,
		Social = 9,
		ShopMall = 10,
		Adventure = 11
	}

	[CompilerGenerated]
	private sealed class _003CPlaySound_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CPlaySound_003Ed__57(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public Action E_OnCard;

	public Action E_OnFormation;

	public Action E_OnLgEquipment;

	public Action E_OnLgSkill;

	public Action E_OnLgItem;

	public Action E_OnShop;

	public Action E_OnCardEnchance;

	public Action E_OnEquipEnchance;

	public Action E_OnItemLianHua;

	public Action E_OnSkillUpgrader;

	public Action E_OnFriend;

	public Action E_OnGuild;

	public Action E_OnChat;

	public Action E_OnPlayPoint;

	public Action E_OnMail;

	public Action E_OnTask;

	public Action E_OnActivity;

	public Action E_OnHongBao;

	public Action E_OnCheckin;

	public Action E_OnProjGrowth;

	public Action E_OnHuoDong;

	public Action E_OnLianHua;

	public Action E_OnVip;

	public Action E_OnAddCrystal;

	public Action E_OnAddGold;

	public Action E_OnAddStamina;

	public Action E_OnShopMistery;

	public Action E_OnPlayerInfo;

	public Action E_OnOpenCele;

	public Action E_OnNextNewFunction;

	public Action E_OnDicIllustion;

	public UIMainStage uiMainStage;

	public UIMainSceneTopPanel topPanel;

	public UIMainSceneBottomPanel bottomPanel;

	private IEnumerator internal_start_void;

	public void SetView(List<ButtonType> hideButtons = null)
	{
		if (topPanel != null)
		{
			if (topPanel.btnMail != null) topPanel.btnMail.gameObject.SetActive(_is_activate_(ButtonType.Mail, hideButtons));
			if (topPanel.btnChat != null) topPanel.btnChat.gameObject.SetActive(_is_activate_(ButtonType.Chat, hideButtons));
			if (topPanel.btnActivity != null) topPanel.btnActivity.gameObject.SetActive(_is_activate_(ButtonType.Activity, hideButtons));
			if (topPanel.btnTask != null) topPanel.btnTask.gameObject.SetActive(_is_activate_(ButtonType.Task, hideButtons));
			if (topPanel.btnHongBao != null) topPanel.btnHongBao.gameObject.SetActive(_is_activate_(ButtonType.Gift, hideButtons));
			if (topPanel.btnCheckin != null) topPanel.btnCheckin.gameObject.SetActive(_is_activate_(ButtonType.Gift, hideButtons));
			if (topPanel.btnProjGrowth != null) topPanel.btnProjGrowth.gameObject.SetActive(_is_activate_(ButtonType.Activity, hideButtons));
			if (topPanel.btnHuoDong != null) topPanel.btnHuoDong.gameObject.SetActive(_is_activate_(ButtonType.Activity, hideButtons));
			if (topPanel.btnLianHua != null) topPanel.btnLianHua.gameObject.SetActive(_is_activate_(ButtonType.Activity, hideButtons));
		}

		if (bottomPanel != null)
		{
			if (bottomPanel.btnParty != null) bottomPanel.btnParty.gameObject.SetActive(_is_activate_(ButtonType.Formation, hideButtons));
			if (bottomPanel.btnCard != null) bottomPanel.btnCard.gameObject.SetActive(_is_activate_(ButtonType.Card, hideButtons));
			if (bottomPanel.btnLuggage != null) bottomPanel.btnLuggage.gameObject.SetActive(_is_activate_(ButtonType.Luggage, hideButtons));
			if (bottomPanel.btnEnchance != null) bottomPanel.btnEnchance.gameObject.SetActive(_is_activate_(ButtonType.Enchance, hideButtons));
			if (bottomPanel.btnSocial != null) bottomPanel.btnSocial.gameObject.SetActive(_is_activate_(ButtonType.Social, hideButtons));
			if (bottomPanel.btnShop != null) bottomPanel.btnShop.gameObject.SetActive(_is_activate_(ButtonType.ShopMall, hideButtons));
			if (bottomPanel.btnPlayPoint != null) bottomPanel.btnPlayPoint.gameObject.SetActive(_is_activate_(ButtonType.Adventure, hideButtons));
		}

		Refresh();
	}

	public void InitMain()
	{
		InitPanel();
	}

	public void Refresh()
	{
		if (topPanel != null)
		{
			topPanel.UpdateEnergy(Me.Ins != null && Me.Ins.PlayerInfo != null ? Me.Ins.PlayerInfo.Energy : 0);
			topPanel.UpdateCheckinRedDot();
		}
	}

	private bool _is_activate_(ButtonType _type, List<ButtonType> hideButton)
	{
		if (hideButton != null)
		{
			return !hideButton.Contains(_type);
		}
		return true;
	}

	private void Update()
	{
	}

	protected override void DoPrepare()
	{
		base.DoPrepare();
		if (uiMainStage == null)
		{
			uiMainStage = UnityEngine.Object.FindObjectOfType<UIMainStage>();
		}
		if (topPanel != null)
		{
			topPanel.Prepare();
		}
		if (bottomPanel != null)
		{
			bottomPanel.Prepare();
		}
		Hook();
		InitPanel();
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void DoShowOnscreen()
	{
		base.DoShowOnscreen();
		if (internal_start_void != null)
		{
			StartCoroutine(internal_start_void);
		}
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void Hook()
	{
		if (uiMainStage != null)
		{
			E_OnFormation += uiMainStage.activateArrayEditor;
			E_OnFriend += uiMainStage.activateFriend;
			E_OnGuild += uiMainStage.activateGuild;
			E_OnCard += uiMainStage.activateCardBag;
			E_OnLgEquipment += uiMainStage.activateGearLuggage;
			E_OnLgItem += uiMainStage.activateItemLuggage;
			E_OnLgSkill += uiMainStage.activateSkillLuggage;
			E_OnShop += uiMainStage.activeShop;
			E_OnCardEnchance += uiMainStage.activateCardEnchance;
			E_OnEquipEnchance += uiMainStage.activeEquipEnchance;
			E_OnSkillUpgrader += uiMainStage.activateSkillUpgrader;
			E_OnLianHua += uiMainStage.activateLianhua;
			E_OnPlayPoint += uiMainStage.activateArena;
		}
		E_OnMail += activeMail;
		E_OnTask += activeTask;
		if (Me.Ins != null)
		{
			Me.Ins.E_OnNameChanged += OnNameChanged;
		}
	}

	private void OnNameChanged()
	{
	}

	private void Dehook()
	{
		if (uiMainStage != null)
		{
			E_OnFormation -= uiMainStage.activateArrayEditor;
			E_OnFriend -= uiMainStage.activateFriend;
			E_OnGuild -= uiMainStage.activateGuild;
			E_OnCard -= uiMainStage.activateCardBag;
			E_OnLgEquipment -= uiMainStage.activateGearLuggage;
			E_OnLgItem -= uiMainStage.activateItemLuggage;
			E_OnLgSkill -= uiMainStage.activateSkillLuggage;
			E_OnShop -= uiMainStage.activeShop;
			E_OnCardEnchance -= uiMainStage.activateCardEnchance;
			E_OnEquipEnchance -= uiMainStage.activeEquipEnchance;
			E_OnSkillUpgrader -= uiMainStage.activateSkillUpgrader;
			E_OnLianHua -= uiMainStage.activateLianhua;
			E_OnPlayPoint -= uiMainStage.activateArena;
		}
		E_OnMail -= activeMail;
		E_OnTask -= activeTask;
		if (Me.Ins != null)
		{
			Me.Ins.E_OnNameChanged -= OnNameChanged;
		}
	}

	public void InitPanel()
	{
		if (topPanel != null)
		{
			topPanel.Prepare();
			topPanel.E_OnAddCrystal = delegate { E_OnAddCrystal?.Invoke(); };
			topPanel.E_OnAddGold = delegate { E_OnAddGold?.Invoke(); };
			topPanel.E_OnAddEnergy = delegate { E_OnAddStamina?.Invoke(); };
			topPanel.E_OnMail = delegate { E_OnMail?.Invoke(); };
			topPanel.E_OnChat = delegate { E_OnChat?.Invoke(); };
			topPanel.E_OnActivity = delegate { E_OnActivity?.Invoke(); };
			topPanel.E_OnTask = delegate { E_OnTask?.Invoke(); };
			topPanel.E_OnHongBao = delegate { E_OnHongBao?.Invoke(); };
			topPanel.E_OnCheckin = delegate { E_OnCheckin?.Invoke(); };
			topPanel.E_OnProjGrowth = delegate { E_OnProjGrowth?.Invoke(); };
			topPanel.E_OnVip = delegate { E_OnVip?.Invoke(); };
			topPanel.E_OnShopMistry = delegate { E_OnShopMistery?.Invoke(); };
			topPanel.E_OnPlayerInfo = delegate { E_OnPlayerInfo?.Invoke(); };
			topPanel.E_OnHuoDong = delegate { E_OnHuoDong?.Invoke(); };
			topPanel.E_OnLianHua = delegate { E_OnLianHua?.Invoke(); };
			topPanel.E_OnIllustDict = delegate { E_OnDicIllustion?.Invoke(); };
			topPanel.E_OnOpenCele = delegate { E_OnOpenCele?.Invoke(); };
			topPanel.E_OnNextNewFunction = delegate { E_OnNextNewFunction?.Invoke(); };
		}

		if (bottomPanel != null)
		{
			bottomPanel.Prepare();
			bottomPanel.E_OnCard = delegate { E_OnCard?.Invoke(); };
			bottomPanel.E_OnParty = delegate { E_OnFormation?.Invoke(); };
			bottomPanel.E_OnShop = delegate { E_OnShop?.Invoke(); };
			bottomPanel.E_OnCardEnchance = delegate { E_OnCardEnchance?.Invoke(); };
			bottomPanel.E_OnEquipEnchance = delegate { E_OnEquipEnchance?.Invoke(); };
			bottomPanel.E_OnSkillUpgrader = delegate { E_OnSkillUpgrader?.Invoke(); };
			bottomPanel.E_OnFriend = delegate { E_OnFriend?.Invoke(); };
			bottomPanel.E_OnGuild = delegate { E_OnGuild?.Invoke(); };
			bottomPanel.E_OnPlayPoint = delegate { E_OnPlayPoint?.Invoke(); };
			bottomPanel.E_OnLgEquipment = delegate { E_OnLgEquipment?.Invoke(); };
			bottomPanel.E_OnLgSkill = delegate { E_OnLgSkill?.Invoke(); };
			bottomPanel.E_OnLgItem = delegate { E_OnLgItem?.Invoke(); };
		}

		SetView(null);
	}

	private void ResuestFerrer1()
	{
	}

	private void ResuestFerrer(bool PurchCrad)
	{
	}

	public void UnInitPanel()
	{
	}

	public void activeMail()
	{
		new Ice.ProjectCos.UI.Intents.MailIntent().Perform(null, true, true, false, true);
	}

	public void activeTask()
	{
		new Ice.ProjectCos.UI.Intents.TaskAchiveIntent().Perform(null, true, true, false, true);
	}

	private void ShowAccSignPanel()
	{
	}

	public void PlayMainScneneSound()
	{
	}

	public void StopMainSceneSound()
	{
	}

	[IteratorStateMachine(typeof(_003CPlaySound_003Ed__57))]
	private IEnumerator PlaySound()
	{
		return null;
	}
}
