using System;
using System.Collections.Generic;
using Ice.ProjectCos.UI.DataModel;
using UnityEngine;

public class UIItemMultiSelector : IceUIBase
{
	public enum ESelectType
	{
		Hero = 0,
		Gear = 1,
		Skill = 2,
		_NUM = 3
	}

	public enum EFilterType
	{
		None = 0,
		SkillUpgrader_MainSkill = 1,
		SkillUpgrader_Material = 2,
		CardLevelup_MainHero = 3,
		CardLevelup_Material = 4,
		CardStrengthener = 5,
		ArrayEditor_AddNew = 6,
		ArrayEditor_Switch = 7,
		GearStrengthener = 8,
		ArmGear_Head = 9,
		ArmGear_Weapon = 10,
		ArmGear_Upper = 11,
		ArmGear_Jewelry = 12,
		ArmSkill_Leader = 13,
		ArmSkill_Assistant = 14,
		ArmSkill_Passive = 15,
		ArmSkill_Initiative = 16,
		Lianhua_NoneArmed = 17,
		_NUM = 18
	}

	public class CardItemVisualizer : IceUIReusableList<HeroCouple>.IVisualizer
	{
		public readonly UIItemMultiSelector Owner;

		public CardItemVisualizer(UIItemMultiSelector owner)
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

		public void SetData(GameObject widget, HeroCouple heroCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class GearItemVisualizer : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly UIItemMultiSelector Owner;

		public GearItemVisualizer(UIItemMultiSelector owner)
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

		public void SetData(GameObject widget, ItemCouple gearCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	public class SkillItemVisualizer : IceUIReusableList<ItemCouple>.IVisualizer
	{
		public readonly UIItemMultiSelector Owner;

		public SkillItemVisualizer(UIItemMultiSelector owner)
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

		public void SetData(GameObject widget, ItemCouple skillCouple)
		{
		}

		public void ClearData(GameObject widget)
		{
		}
	}

	[SerializeField]
	private UIEventListener HomePageButton;

	[SerializeField]
	private UIEventListener ReturnButton;

	[SerializeField]
	private UIEventListener EnsureButton;

	[SerializeField]
	private IceUIBtnGroup ItemTypeTab;

	[SerializeField]
	private UICardItemList cardList;

	[SerializeField]
	private UIItemList gearList;

	[SerializeField]
	private UIItemList skillList;

	[SerializeField]
	private UILabel lblRemain;

	public Action OnReturn;

	public Action OnHomePage;

	public Action<List<ItemHolding>> OnItemSelect;

	public Action<List<Hero>> OnCardSelect;

	private ESelectType selectType;

	private EFilterType filterType;

	private List<int> CardsOnField;

	private Dictionary<int, ItemHolding> Holdings;

	private Dictionary<int, Hero> Heroes;

	private List<ItemHolding> ItemCart;

	private List<Hero> HeroCart;

	public void SetData(ESelectType selecttype, int limitCount = -1, List<Hero> selectedHeroes = null, List<ItemHolding> selectedHoldings = null, Hero mainHero = null, ItemHolding mainHolding = null, EFilterType filtertype = EFilterType.None)
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

	protected override void PlayEnterEffects(Action onEnterScreen)
	{
	}

	protected override void PlayExitEffects(Action onExitScreen)
	{
	}

	private List<Hero> filterHeroListOnlyBattleFieldHeroCards(List<Hero> heroes)
	{
		return null;
	}

	private List<Hero> filterHeroListForSwitch(List<Hero> heroes, Hero mainhero)
	{
		return null;
	}

	private List<Hero> filterHeroListForAddNew(List<Hero> heroes)
	{
		return null;
	}

	private void OnHomeClicked(GameObject obj)
	{
	}

	private void OnReturnClicked(GameObject obj)
	{
	}

	private void OnEnsureClicked(GameObject obj)
	{
	}

	private void setStatus(string oldTabName, string newTabName)
	{
	}

	private bool isCartEmpty()
	{
		return false;
	}

	private void OnCardSelected(Hero holding, bool isSelected)
	{
	}

	private void OnHoldingSelected(ItemHolding holding, bool isSelected)
	{
	}

	private void OnGearUnload(ItemHolding gear)
	{
	}

	private void OnSkillUnload(ItemHolding skill)
	{
	}
}
