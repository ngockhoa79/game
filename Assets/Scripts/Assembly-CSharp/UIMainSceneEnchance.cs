using System;

public class UIMainSceneEnchance : IceUIBase
{
	public UIEventListener btnCardEnchance;

	public UIEventListener btnEquipEnchance;

	public UIEventListener btnSkillUpgrader;

	public Action E_OnCardEnchance;

	public Action E_OnEquipEnchance;

	public Action E_OnSkillUpgrader;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	protected override void DoPrepare()
	{
		if (btnCardEnchance != null)
		{
			btnCardEnchance.onClick = (go) => { if (E_OnCardEnchance != null) E_OnCardEnchance(); };
		}
		if (btnEquipEnchance != null)
		{
			btnEquipEnchance.onClick = (go) => { if (E_OnEquipEnchance != null) E_OnEquipEnchance(); };
		}
		if (btnSkillUpgrader != null)
		{
			btnSkillUpgrader.onClick = (go) => { if (E_OnSkillUpgrader != null) E_OnSkillUpgrader(); };
		}
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
		if (onEnterScreen != null) onEnterScreen();
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
		if (onExitScreen != null) onExitScreen();
	}
}
