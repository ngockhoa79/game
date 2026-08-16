using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIFragmentCombine : IceUIBase
{
	public class SkillFragmentVisualizer : IceUIReusableList<Skill>.IVisualizer
	{
		public readonly UIFragmentCombine Owner;

		public SkillFragmentVisualizer(UIFragmentCombine owner)
		{
		}

		public GameObject CreateWidget(Transform widgetsHolder)
		{
			return null;
		}

		public GameObject CreateSeparator(Transform widgetsHolder)
		{
			return null;
		}

		public void SetData(GameObject widget, Skill item)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public UIEventListener btnBack;

	public UIEventListener btnHomePage;

	public UIEventListener btnReport;

	public UIEventListener btnNotice;

	public UIEventListener btnRule;

	public UIEventListener btnBatch;

	public UIFragmentRobList List;

	public UICircleSlotsController CircleSlotCtrller;

	public UniIcon CenterIcon;

	public UIEventListener btnPreview;

	public UIEventListener btnNext;

	public UIEventListener btnCombine;

	public UIEventListener btnCombineGray;

	public IceAnimatorTotalCommander animCombineButton;

	public IceAnimatorTotalCommander animCenterEnter;

	public IceAnimatorTotalCommander animCenterEnchance;

	public IceAnimatorTotalCommander animCombineAnimation;

	public UILabel lbCurSkillName;

	public UILabel lbCurFragmentProgress;

	public IceAnimatorTotalCommander anim_empty;

	public GameObject goEmptyLeft;

	public GameObject goEmptyRight;

	public Action E_OnBack;

	public Action E_OnHomePage;

	public Action E_OnReport;

	public Action E_OnNotice;

	public Action E_OnRule;

	public Action<List<int>> E_OnBatch;

	public Action<int> E_OnRobSkillFragment;

	public Action<int> E_OnCombineSkill;

	private Skill curSelectedSkill;

	public Skill defaultSelectSkill;

	public UIFragmentPreventInfo PreventInfo;

	public Skill CurSelectedSkill => null;

	public void OnItemClicked(Skill skill, Action cb = null)
	{
	}

	private void SetDataCircleSlotCtrller(Skill skill, UICircleSlotsController circleSlotCtrller)
	{
	}

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoShowOnscreen()
	{
	}

	protected override void DoShowOffscreen()
	{
	}

	public void PlayEnchanceAnimation(Action onCallback)
	{
	}

	private void RefreshInternalData()
	{
	}

	private void RefreshDefaultSelect()
	{
	}

	public void Refresh()
	{
	}

	private Skill GetPreSkill()
	{
		return null;
	}

	private Skill GetDefaultSelectSkill()
	{
		return null;
	}

	private Skill GetNextSkill()
	{
		return null;
	}

	private int GetCurSkillIndex()
	{
		return 0;
	}

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	protected override void DoClearData()
	{
	}

	protected override void DoDispose()
	{
	}

	private List<Skill> GetCanbimeList(MonintoredList<ItemHolding> fragmentList)
	{
		return null;
	}

	private void OnFragmentSelected(SkillFragment skillFragment, AbstractItem item)
	{
	}

	public void ShowEmpty()
	{
	}

	private void setPreventInfo(Skill s)
	{
	}

	private List<int> getBatchSkillIds()
	{
		return null;
	}
}
