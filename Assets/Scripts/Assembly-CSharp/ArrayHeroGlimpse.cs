using System;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class ArrayHeroGlimpse : IceUIBase
{
	[SerializeField]
	private UICmSkillIcon[] Skills;

	[SerializeField]
	private UICmItemIcon[] Gears;

	[SerializeField]
	private Transform FunnyRendererPlaceHolder;

	private GameObject funnyRenderer;

	[SerializeField]
	private UILabel DescText;

	[SerializeField]
	private UILabel HeroName;

	[SerializeField]
	private UILabel CurLevel;

	[SerializeField]
	private UILabel MaxLevel;

	[SerializeField]
	private UILabel PowerText;

	[SerializeField]
	private UILabel HealthText;

	[SerializeField]
	private UILabel DefenceText;

	[SerializeField]
	private UILabel AttackText;

	[SerializeField]
	private UILabel SpiritText;

	[SerializeField]
	private UIEventListener ReplaceTxtBtn;

	[SerializeField]
	private UIEventListener CloseTrigger;

	public Action OnClosed;

	public Action<Hero> OnReplaced;

	private Hero card;

	protected override void DoInit()
	{
	}

	protected override void DoPrepare()
	{
	}

	protected override void DoDispose()
	{
	}

	private void clearCard()
	{
	}

	public void SetDetails(Hero card, bool canBeReplaced)
	{
	}

	private void handleReplaced(GameObject btn)
	{
	}

	private void handleClosed(GameObject btn)
	{
	}

	private void loadSkillInfo(Hero card)
	{
	}

	private void loadGearInfo(Hero card)
	{
	}

	private void loadUIHero(int configID)
	{
	}

	private void loadProperties(Hero card)
	{
	}

	private void loadCouplings()
	{
	}

	public void ActivateFunnyRenderer(bool activated)
	{
	}
}
