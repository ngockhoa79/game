using System;

public class UIMainSceneLuggage : IceUIBase
{
	public UIEventListener btnEquipment;

	public UIEventListener btnSkill;

	public UIEventListener btnItem;

	public Action E_OnEquipment;

	public Action E_OnSkill;

	public Action E_OnItem;

	public IceAnimatorTotalCommander anim_in;

	public IceAnimatorTotalCommander anim_out;

	protected override void DoPrepare()
	{
		if (btnEquipment != null)
		{
			btnEquipment.onClick = (go) => { if (E_OnEquipment != null) E_OnEquipment(); };
		}
		if (btnSkill != null)
		{
			btnSkill.onClick = (go) => { if (E_OnSkill != null) E_OnSkill(); };
		}
		if (btnItem != null)
		{
			btnItem.onClick = (go) => { if (E_OnItem != null) E_OnItem(); };
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
