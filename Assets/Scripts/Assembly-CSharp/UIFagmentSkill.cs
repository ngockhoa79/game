using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFagmentSkill : IceUIBase
{
	private const string FragPrefix = "frag";

	public UICmSkillIcon icon;

	public IceAnimatorTotalCommander enterScreenAnimator;

	public IceAnimatorTotalCommander exitScreenAnimator;

	public IceAnimatorTotalCommander[] stayAnimatorList;

	public UISprite[] spLineList;

	public UIEventListener onEvent;

	public GameObject bubbleRoot;

	public UILabel lbCount;

	public UISprite imgName;

	public Action<SkillFragment, AbstractItem> E_OnClicked;

	private IceAnimatorTotalCommander stayAnimator;

	private SkillFragment _skillFragment;

	private int _lineId;

	private int _count;

	public void SetSkillFragment(SkillFragment skillFragment, int fragmentIndex, int lineId, bool bShowIcon, int count)
	{
	}

	private void InitLinePosition()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	private void Update()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoPrepare()
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

	private void RandomStayAnimator()
	{
	}

	private void ClearStayAnimator()
	{
	}
}
