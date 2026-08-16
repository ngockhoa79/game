using System;

public class UIMainSceneBottomPanel : IceUIBase
{
	public UIMainSceneEnchance enchancePanel;

	public UIMainSceneLuggage luggagePanel;

	public UIMainSceneSocial socialPanel;

	public UINotifyRedDot rdParty;

	public UIEventListener btnParty;

	public UIEventListener btnCard;

	public UIEventListener btnLuggage;

	public UIEventListener btnEnchance;

	public UIEventListener btnSocial;

	public UIEventListener btnShop;

	public UIEventListener btnPlayPoint;

	public Action E_OnCard;

	public Action E_OnParty;

	public Action E_OnShop;

	public Action E_OnCardEnchance;

	public Action E_OnEquipEnchance;

	public Action E_OnSkillUpgrader;

	public Action E_OnFriend;

	public Action E_OnGuild;

	public Action E_OnPlayPoint;

	public Action E_OnLgEquipment;

	public Action E_OnLgSkill;

	public Action E_OnLgItem;

	public UINotifyRedDot rdPlayPoint;

	public UINotifyRedDot rdGearFragment;

	public UINotifyRedDot rdCardFragment;

	public UINotifyRedDot rdLuggage;

	private IceUIBase openTooltipPanel;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
		if (btnCard != null) btnCard.onClick = (go) => E_OnCard?.Invoke();
		if (btnShop != null) btnShop.onClick = (go) => E_OnShop?.Invoke();
		if (btnPlayPoint != null) btnPlayPoint.onClick = (go) => E_OnPlayPoint?.Invoke();
		if (btnLuggage != null) btnLuggage.onClick = (go) => OpenToolWindow(luggagePanel);
		if (btnEnchance != null) btnEnchance.onClick = (go) => OpenToolWindow(enchancePanel);
		if (btnSocial != null) btnSocial.onClick = (go) => OpenToolWindow(socialPanel);
	}

	protected override void DoClearData()
	{
		CloseManual();
	}

	protected override void DoDispose()
	{
		CloseManual();
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
		onEnterScreen?.Invoke();
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
		onExitScreen?.Invoke();
	}

	private void OpenToolWindow(IceUIBase panel = null, Action callback = null)
	{
		if (openTooltipPanel != null && openTooltipPanel != panel)
		{
			openTooltipPanel.gameObject.SetActive(false);
		}
		openTooltipPanel = panel;
		if (openTooltipPanel != null)
		{
			openTooltipPanel.gameObject.SetActive(true);
		}
		callback?.Invoke();
	}

	public void CloseManual(Action callback = null)
	{
		if (openTooltipPanel != null)
		{
			openTooltipPanel.gameObject.SetActive(false);
			openTooltipPanel = null;
		}
		callback?.Invoke();
	}
}
