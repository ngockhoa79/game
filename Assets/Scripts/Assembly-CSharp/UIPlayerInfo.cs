using System;
using UnityEngine;

public class UIPlayerInfo : IceUIBase
{
	public Action E_OnAddGold;

	public Action E_OnAddCrystal;

	public Action E_OnAddStamina;

	public Action E_OnGongao;

	public Action E_OnSettings;

	public Action E_ChangeGuild;

	public Action E_OnClose;

	public Action E_OnLogout;

	public UICmItemIcon headIcon;

	public UILabel lbID;

	public UILabel lbName;

	public UILabel lbFightValue;

	public UILabel lbLevel;

	public UILabel lbExp;

	public UILabel lbSignature;

	public UISprite spExp;

	public UISprite spVip;

	public UILabel lbHeroCount;

	public UILabel lbEquipmentLevel;

	public UILabel lbHeroLevel;

	public UILabel lbFriendVal;

	public UILabel lbReputationVal;

	public UILabel lbSmeltVal;

	public UILabel lbLianHua;

	public UILabel lbGold;

	public UILabel lbCrystal;

	public UILabel lbStamina;

	public GameObject GuildInfo;

	public GameObject NoGuildInfo;

	public UILabel lbGuildName;

	public UIInput inputSignature;

	public UIEventListener btnChangeName;

	public UIEventListener btnAddGold;

	public UIEventListener btnAddCrystal;

	public UIEventListener btnAddStamina;

	public UIEventListener btnChangePortra;

	public UIEventListener btnUserCenter;

	public UIEventListener btnGonggao;

	public UIEventListener btnSettings;

	public UIEventListener btnChangeGuild;

	public UIEventListener btnLogout;

	public UIEventListener btnTuichu;

	public UIEventListener btnClose;

	public UILabel lbEnergyRemaining;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	public UIEventListener btnSignature;

	private void SetPortra()
	{
	}

	private void Start()
	{
	}

	private void Set()
	{
	}

	private void Update()
	{
	}

	private void _refresh_energy_remaining()
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

	protected override void DoDispose()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private void OnSignatureSubmit()
	{
	}

	private void Hook()
	{
	}

	private void OnNameChanged()
	{
	}

	private void Dehook()
	{
	}

	public void OnChangePortraClicked(GameObject btn)
	{
	}

	public void OnPortraChanged(int heroID)
	{
	}

	public void UpdateGuildInfoUI()
	{
	}

	public void Tuichu()
	{
	}
}
