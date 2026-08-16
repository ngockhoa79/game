using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;

public class UIFragmentContent : IceUIBase
{
	public UICmSkillIcon skillIcon;

	public UILabel lbName;

	public UILabel lbCount;

	public UISprite spCanCombine;

	public UISprite spUnderPrevention;

	public UISprite spBg;

	public UISprite nameBg;

	public UIEventListener collider;

	public IceAnimatorTotalCommander enterAnim;

	public IceAnimatorTotalCommander exitAnim;

	public Action<Skill> E_OnClicked;

	private Skill _data;

	private List<ItemHolding> fragmentList;

	private List<SkillFragment> allFragmentList;

	private bool _selected;

	private Timer t;

	public Skill Skill => null;

	public int MaxSlotCount => 0;

	public List<ItemHolding> FragmentList => null;

	public List<SkillFragment> AllFragmentList => null;

	public void SetData(Skill skill)
	{
	}

	public void Select(bool bSelected)
	{
	}

	private void ClearData()
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

	public void TurnOnPreventionIcon(bool active)
	{
	}

	private bool isUnderPrevention(Skill s)
	{
		return false;
	}
}
