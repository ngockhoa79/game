using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UICircleSlotsController : IceUIBase
{
	public UICircleSlotsData data;

	public GameObject centerGo;

	public Action<SkillFragment, AbstractItem> E_OnItemClicked;

	public Action<bool> E_OnShowCombineButton;

	public GameObject lbTips;

	private int _maxSlotCount;

	private bool _bFirst;

	private bool _bLast;

	private List<UIFagmentSkill> subList;

	private List<ItemHolding> _items;

	private List<SkillFragment> _allFragments;

	private Skill _skill;

	public void SetData(Skill skill, int max_slot_count, List<ItemHolding> items, List<SkillFragment> allFragments)
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private bool CreateSlots(int maxSlotCount, List<ItemHolding> items, List<SkillFragment> allFragments)
	{
		return false;
	}
}
