using System;
using Ice.ProjectCos.UI.DataModel;

public class UISkillPopup : IceUIBase
{
	public UICmItemIcon Icon;

	public UIStarsRow Stars;

	public UILabel NameText;

	public UILabel DescText;

	public UIEventListener bnCancel;

	public UIEventListener bnUpgrade;

	public UIEventListener bnReplace;

	public UIEventListener bnClose;

	public Action<SkillHolding> OnChange;

	public Action<SkillHolding> OnUpgrade;

	public Action<SkillHolding> OnCancel;

	private SkillHolding holding;

	public SkillHolding Holding => null;

	private void clear()
	{
	}

	public void SetData(SkillHolding holding, bool showOtherBtn)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}
}
